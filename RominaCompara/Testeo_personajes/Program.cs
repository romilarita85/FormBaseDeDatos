using LibreriaDePersonajes;
namespace Testeo_personajes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personaje personajeUno = new Heroe("Bruce Wayne", "Batman", "Ciudad gotica", "La liga de la justicia");
            //personajeUno.Id = 5;// para modificar el personaje con id = 5
            personajeUno.SetID(5);
            Personaje personajeDos = new Heroe("lol", "Acertijo", "Ciudad gotica", "La liga de la justicia");
            //Personaje personajeTres = personajeUno; // comparten la misma direccion de memoria (van a dar true)

            personajeUno.SetHabilidad("inteligencia");

            //if (Personaje_Ado.Escribir(personajeDos))
            //{
            //    Console.WriteLine("Guardado con exito");

            //}
            //else
            //{
            //    Console.WriteLine("Error al intentar conectarse a la base de datos");
            //}
            //---------------PARA TESTEAR METODO LEER UNO--------------------------------

            //Personaje p1 = Personaje_Ado.LeerUno(personajeUno);
            ////Personaje p1 = Personaje_Ado.LeerUno(5);//-Caso de que reciba un id (un entero q represente el id)
            ////con el Metodo LeerUno
            //Console.WriteLine($"Id: {p1.Id} - nombrePersonaje: {p1.NombrePersonaje}");

            //-----------------PARA TESTEAR METODO LEER TODOS-----------------------
            //List<Personaje> misPersonajes = Personaje_Ado.LeerTodos();
            ////Declaro una lista y le asigno el valor de leer todos

            //foreach (Personaje item in misPersonajes)
            //{
            //    Console.WriteLine($"Id: {item.Id} - nombrePersonaje: {item.NombrePersonaje}");
            //}
            //------------------------PARA TESTERA METODO ELIMINAR---------------------------------------------------
            //Personaje p1 = Personaje_Ado.LeerUno(6);
            //Console.WriteLine($"Id: {p1.Id} - nombrePersonaje: {p1.NombrePersonaje}");

            //if (Personaje_Ado.Eliminar(6))
            //{
            //    Console.WriteLine("Eliminado con exito");

            //}
            //else
            //{
            //    Console.WriteLine("Error al intentar eliminar de la base de datos");
            //}
            //Personaje p2 = Personaje_Ado.LeerUno(6); // al intentar leerlo nuevamente 
            //if (p2 is not null) 
            //{
            //    Console.WriteLine("El personaje se encuentra en la DB");
            //}
            //else 
            //{
            //    Console.WriteLine("El personaje no se encuentra en la DB");
            //}
            //____________________________Para testear metodo modificar----------------------
            //if (Personaje_Ado.Modificar(personajeUno)) 
            //{
            //    Console.WriteLine("Modificado con exito");
            //}
            //else
            //{
            //    Console.WriteLine("Error al intentar eliminar de la base de datos");
            //}
            //Personaje p2 = Personaje_Ado.LeerUno(personajeUno.Id); // al intentar leerlo nuevamente 
            //if (p2 is not null)
            //{
            //    Console.WriteLine(personajeUno);
            //}
            //else
            //{
            //    Console.WriteLine("El personaje no se encuentra en la DB");
            //}
            //---------------------------METDOD MODIFICARPORCAMPO-----------------------------------

            //if(Personaje_Ado.ModificarPorCampo("NombreReal","Jacinto", "NombrePersonaje = 'Acertijo' "))
            //{
            //    Console.WriteLine("Exito");
            //}
            //else 
            //{
            //    Console.WriteLine("Fallo");
            //}
            //------------------------METODO MODIFICAR POR LUGAR DE ORIGEN SEGUN ALIANZA------------------
            //se modifica el lugar de origen
            //if (Personaje_Ado.ModificarPorLugarDeOrigenSegunAlianza("N.Y.", "La liga de la justicia"))
            //{
            //    Console.WriteLine("Exito");
            //}
            //else
            //{
            //    Console.WriteLine("Fallo");
            //}
            //---------------------METODO PARA MODIFICAR ALIANZA POR ID-------------------------
            //se actualiza la alianza del id 2 al 4 en la base de datos
            if (Personaje_Ado.ModificarAlianzaPorRangoDeId("X-MEN",2,4))
            {
                Console.WriteLine("Exito");
            }
            else
            {
                Console.WriteLine("Fallo");
            }


            ////Usando Equals para comparaciones:
            //Console.WriteLine($"La comparacion entre PersonajeUno y PersonajeDos:{personajeUno.Equals(personajeDos)}");
            //Console.WriteLine($"La comparacion entre PersonajeUno y PersonajeTres:{personajeUno.Equals("Bruce Wayne")}");
            //Console.WriteLine($"La comparacion entre PersonajeDos y PersonajeTres:{personajeDos.Equals(personajeTres)}");

        }

    }
}

////1-COMPARACION POR UNA POSICION DE MEMORIA
//Console.WriteLine($"La comparacion entre PersonajeUno y PersonajeDos:{personajeUno == personajeDos}");
//Console.WriteLine($"La comparacion entre PersonajeUno y PersonajeTres:{personajeUno == personajeTres}");
//Console.WriteLine($"La comparacion entre PersonajeDos y PersonajeTres:{personajeUno == personajeDos}");

////2-COMPARACION POR UNA CAMPO ESPECIFICO CON UN VALOR DETERMINADO: (todas deberian dar true)
//Console.WriteLine($"La comparacion entre PersonajeUno y PersonajeDos:{personajeUno.NombreReal == personajeDos.NombreReal}");
//Console.WriteLine($"La comparacion entre PersonajeUno y PersonajeTres:{personajeUno.NombreReal == "Bruce Wayne"}");
//Console.WriteLine($"La comparacion entre P