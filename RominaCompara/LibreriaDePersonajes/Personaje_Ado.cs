using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDePersonajes
{
    public static class Personaje_Ado
    { //atributos:
        private static string connectionsString;// de tipo string
        private static MySqlConnection connection;// de tipo objeto mysql
        private static MySqlCommand command;//de tipo objeto musql

        //constructor estatico
        static Personaje_Ado()
        {//dar valor al connectionstring
            connectionsString = "server=localhost;database=superheroes;uid=root;pwd=;";

            //crear nueva instancia de mysqlconnection
            connection = new MySqlConnection(connectionsString);

            //crear nueva instancia del objeto mysqlcommand
            command = new MySqlCommand();

            //darla valores a dos de sus properties
            //-el tipo de dato q va a estar recibiendo(comando de tipo texto)
            command.CommandType = System.Data.CommandType.Text;
            //-de donde va a obtener la conexion
            command.Connection = connection;
            ///la conexion la va a obtener del "server localhost;database= superheroes....."
        }
        //METODO DE ESCRITURA
        public static bool Escribir(Personaje psj) //recibe un personaje
        {
            //try: metodo para atrapar exepciones
            bool exito = true;//va a devolver un booleano-> me va a decir si pudo escribir en la base de datos o si 
                              //hubo un problema
            try
            {
                // para extraer valores sin importar el tipo de datos
                string alianza = string.Empty;
                string planMalvado = string.Empty;
                //ver si el objeto q estamos recibiendo por parametro es del tipo heroe o villano
                if (psj.GetType().Name == typeof(Heroe).Name)
                {
                    alianza = ((Heroe)psj).Alianza;//dato q los diferencia ->alianza
                    //casteo () y lo encierro entre parentesis () para acceder a sus propiedades
                }
                else
                {
                    planMalvado = ((Villano)psj).PlanMalvado;//dato q los diferencia ->plan malvado
                }

                OpenConnection("INSERT INTO personajes(NombrePersonaje, NombreReal, Habilidades, LugarDeOrigen, PlanMalvado, Alianza) VALUES(@NombrePersonaje,@NombreReal, @Habilidades, @LugarDeOrigen,@PlanMalvado,@Alianza)");
                //Vamos agregando valores de las variables(de donde va salir el valor)
                command.Parameters.AddWithValue("@NombrePersonaje", psj.NombrePersonaje);
                command.Parameters.AddWithValue("@NombreReal", psj.NombreReal);
                command.Parameters.AddWithValue("@Habilidades", psj.Habilidades);
                command.Parameters.AddWithValue("@LugarDeOrigen", psj.LugarDeOrigen);
                command.Parameters.AddWithValue("@PlanMalvado", planMalvado);
                command.Parameters.AddWithValue("@Alianza", alianza);

                command.ExecuteNonQuery();//utilizo el comando executenon

            }
            catch (Exception) //(cuando no se puede ejecutar try)atrapa la excepciones, errores o problemas.
            {
                exito = false;
            }
            finally //siempre se va a ejecutar 
            {//ver si la conexion existe
               CloseConnection();
            }
            return exito;


        }
        //METODO LEER TODOS me devuelve una lista instanciada o nula-Para traer todos los personajes
        public static List<Personaje> LeerTodos()
        {//siempre instanciar lista
            List<Personaje> list = new List<Personaje>();
            string query = string.Empty;
            try
            {
                query = "SELECT * FROM personajes";
                command.Connection.Open(); //abro coneccion-connection tiene q abrirse
             
                command.CommandText = query;
                using (MySqlDataReader reader = command.ExecuteReader())
                {//using= abre y cierra una lectura de archivos. Destruye cualquier tipo de remanente o instancia q haya guardado 
                    while (reader.Read()) // Vamos a evaluar si nuestro objeto reader puede ejecutar el metodo de lectura 
                    { //Read()= devuelve un booleano-si logro leer la linea(fila de personajes-xampp) o ya no quedan mas lineas por leer 
                      //mientras pueda seguir leyendo voy sacando los campos(Id,nombrePersonaje etc) de cada linea y los voy a guardar dentro de una variable
                      //Datos-sales de las columnas de tabla personajes

                        //int Id = reader.GetInt32("id"); //traer como un entero del campo id
                        int id = reader.GetInt32(0);//traer el campo de la posicion cero.Pasar el valor de la columna             
                        string NombrePersonaje = reader["NombrePersonaje"].ToString();//
                        string NombreReal = reader.GetString(2);//reader en posicion del elemento-columna 2
                        string Alianza = string.Empty;
                        string PlanMalvado = string.Empty;
                        string Habilidades = string.Empty;
                        //Al leer algo nulo -> hacer validacion(caso Habilidades,PlanMalvado,Alianza)
                        if (!reader.IsDBNull(reader.GetOrdinal("Habilidades")))
                        {
                            Habilidades = reader.GetString(3);
                        }
                        string LugarDeOrigen = reader.GetString(4);

                        if (!reader.IsDBNull(reader.GetOrdinal("PlanMalvado")))
                        {
                            PlanMalvado = reader.GetString(5);
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("Alianza")))
                        {
                            Alianza = reader.GetString(6);
                        }

                        //Ver que tipo de personaje estoy creando.Para ver cuando es heroe o villano-
                        if (string.IsNullOrEmpty(Alianza)) //si no tengo valores en alianza va a ser un villano
                        {
                            Villano v = new Villano(NombreReal, NombrePersonaje, LugarDeOrigen, PlanMalvado);
                            v.SetID(id);
                            v.CargarHabilidadesDesdeString(Habilidades);
                            list.Add(v);
                        }
                        else
                        {
                            Heroe h = new Heroe(NombreReal, NombrePersonaje, LugarDeOrigen, Alianza);
                            h.SetID(id);
                            h.CargarHabilidadesDesdeString(Habilidades);
                            list.Add(h);
                        }
                    }
                }
            }
            catch (Exception)
            {//desreferenciar lista
                list = null;
            }
            finally
            {
                CloseConnection();
            }
            return list;
        }
        //METODO PARA LEER UNO-devuelve algo de tipo personaje
        public static Personaje LeerUno(int idBuscar)//>recibir entero q represente el id
        {// public static Personaje LeerUno(Personaje p) // recibo un personaje por parametro
            Personaje personaje = null;//declaro una variable de tipo personaje por q tengo q retornar
                                       //algo del tipo personaje
            try
            {
                string query = "SELECT * FROM `personajes` WHERE `Id`= @personajeBuscado";
                command.Connection.Open(); //abro coneccion-connection tiene q abrirse
                command.CommandText = query;
                command.Parameters.Clear();
                //command.Parameters.AddWithValue("@personajeBuscado",p.Id);/7pasar parametro
                command.Parameters.AddWithValue("@personajeBuscado",idBuscar);//-> pasarle el id
                using (MySqlDataReader reader = command.ExecuteReader()) // para leer una sola linea del archivo(una fila y sus columnas)
                {
                    reader.Read();//Read()= devuelve un booleano-si logro leer la linea(fila de personajes-xampp) o ya no quedan mas lineas por leer 
                    int id = reader.GetInt32(0);//traer el campo de la posicion cero.Pasar el valor de la columna             
                    string NombrePersonaje = reader.GetString(1);//
                    string NombreReal = reader.GetString(2);//reader en posicion del elemento-columna 2
                    string Alianza = string.Empty;
                    string PlanMalvado = string.Empty;
                    string Habilidades = string.Empty;
                    //Al leer algo nulo -> hacer validacion(caso Habilidades,PlanMalvado,Alianza)
                    if (!reader.IsDBNull(reader.GetOrdinal("Habilidades")))
                    {
                        Habilidades = reader.GetString(3);
                    }
                    string LugarDeOrigen = reader.GetString(4);

                    if (!reader.IsDBNull(reader.GetOrdinal("PlanMalvado")))
                    {
                        PlanMalvado = reader.GetString(5);
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("Alianza")))
                    {
                        Alianza = reader.GetString(6);
                    }

                    //Ver que tipo de personaje estoy creando.Para ver cuando es heroe o villano-
                    if (string.IsNullOrEmpty(Alianza)) //si no tengo valores en alianza va a ser un villano
                    {
                        Villano v = new Villano(NombreReal, NombrePersonaje, LugarDeOrigen, PlanMalvado);
                        v.SetID(id);
                        v.CargarHabilidadesDesdeString(Habilidades);
                        personaje = v;
                   
                    }
                    else
                    {
                        Heroe h = new Heroe(NombreReal, NombrePersonaje, LugarDeOrigen, Alianza);
                        h.SetID(id);
                        h.CargarHabilidadesDesdeString(Habilidades);
                        personaje = h;
                    
                    }
                }
            }
            catch(Exception) 
            {
                personaje = null;
            }
            finally
            {
                CloseConnection();
            }
            return personaje;
        }
        //METODO PARA BORRAR 
        public static bool Eliminar(int idEliminar) 
        {
            bool exito = true;//tetornamos booleano
            try 
            {
                string query = "DELETE FROM `personajes` WHERE `Id`= @personajeBuscado";
                OpenConnection(query);
                command.Parameters.AddWithValue("@personajeBuscado",idEliminar);//paso parametros q tengo q pasarle a la query
                command.ExecuteNonQuery();//agarrar la query y ejecutarla
            
            }
            catch(Exception) 
            {
                exito = false;
            }
            finally 
            {
                CloseConnection();
            }
            return exito;
        }
        //METODO PARA MODIFICAR
        public static bool Modificar(Personaje psj)
        {
            //try: metodo para atrapar exepciones
            bool exito = true;//va a devolver un booleano-> me va a decir si pudo escribir en la base de datos o si 
                              //hubo un problema
            try
            {
                // para extraer valores sin importar el tipo de datos
                string alianza = string.Empty;
                string planMalvado = string.Empty;
                //ver si el objeto q estamos recibiendo por parametro es del tipo heroe o villano
                if (psj.GetType().Name == typeof(Heroe).Name)
                {
                    alianza = ((Heroe)psj).Alianza;//dato q los diferencia ->alianza
                    //casteo () y lo encierro entre parentesis () para acceder a sus propiedades
                }
                else
                {
                    planMalvado = ((Villano)psj).PlanMalvado;//dato q los diferencia ->plan malvado
                }

                OpenConnection("UPDATE personajes SET NombrePersonaje = @NombrePersonaje, NombreReal= @NombreReal, Habilidades= @Habilidades,`LugarDeOrigen`= @LugarDeOrigen,`PlanMalvado`= @PlanMalvado,`Alianza`= @Alianza WHERE id = @id");
                //Cargar los parametros q preciso
                command.Parameters.AddWithValue("@id",psj.GetId);
                command.Parameters.AddWithValue("@NombrePersonaje", psj.NombrePersonaje);
                command.Parameters.AddWithValue("@NombreReal", psj.NombreReal);
                command.Parameters.AddWithValue("@Habilidades", psj.Habilidades);
                command.Parameters.AddWithValue("@LugarDeOrigen", psj.LugarDeOrigen);
                command.Parameters.AddWithValue("@PlanMalvado", planMalvado);
                command.Parameters.AddWithValue("@Alianza", alianza);
             
                command.ExecuteNonQuery();//Ejecutar la query

            }
            catch (Exception) //(cuando no se puede ejecutar try)atrapa la excepciones, errores o problemas.
            {
                exito = false;
            }
            finally //siempre se va a ejecutar 
            {//ver si la conexion existe
                CloseConnection();
            }
            return exito;
        }
        public static bool ModificarPorCampo(string campo,string valor, string condicion)
        {
          
            bool exito = true;
            try
            {
                OpenConnection($"UPDATE personajes SET {campo} = '{valor}' WHERE {condicion}");
                command.ExecuteNonQuery();//Ejecutar la query
            }
            catch (Exception ex) 
            {
                string msg = ex.Message;
                exito = false;
            }
            finally //siempre se va a ejecutar 
            {//ver si la conexion existe
                CloseConnection();
            }
            return exito;
        }
        public static bool ModificarPorLugarDeOrigenSegunAlianza(string nuevoValor, string alianza)
        {

            bool exito = true;
            try
            {
                OpenConnection("UPDATE personajes SET lugarDeOrigen = @nuevoValor WHERE Alianza = @alianza");
                //paso valores por parametros
                command.Parameters.AddWithValue("@nuevoValor",nuevoValor);
                command.Parameters.AddWithValue("@alianza", alianza);
                command.ExecuteNonQuery();//Ejecutar la query
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                exito = false;
            }
            finally //siempre se va a ejecutar 
            {//ver si la conexion existe
                CloseConnection();
            }
            return exito;
        }
        public static bool ModificarAlianzaPorRangoDeId(string nuevoValor, int min, int max)
        {

            bool exito = true;
            try
            {
                OpenConnection("UPDATE personajes SET Alianza = @nuevoValor WHERE id BETWEEN @min AND @max");
                //paso valores por parametros
                command.Parameters.AddWithValue("@nuevoValor", nuevoValor);
                command.Parameters.AddWithValue("@min", min);
                command.Parameters.AddWithValue("@max", max);
                command.ExecuteNonQuery();//Ejecutar la query
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                exito = false;
            }
            finally //siempre se va a ejecutar 
            {//ver si la conexion existe
                CloseConnection();
            }
            return exito;
        }
        private static void OpenConnection(string query) 
        {
            command.Connection.Open();//abrir la conexion
            command.CommandText = query;//pasarle la query
            command.Parameters.Clear();//Limpiar los parametros
        }
        private static void CloseConnection() 
        {
            if (command.Connection is not null && command.Connection.State == System.Data.ConnectionState.Open)
            {
                command.Connection.Close(); //cerrar connection
            }
        }

    }

}
//command.Connection.Open(); //abro coneccion-connection tiene q abrirse
//                           //agregar con parametros: agregar dentro de sus parametros um valor de las variables con las q estoy trabajando

//command.CommandText = query; //le paso el comando q quiero ejecutar.pedirle al comando q ejecute esa query
//command.Parameters.Clear();