using System.Drawing;
using System;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaDePersonajes
{
    public abstract class Personaje
    {
        //Atributos:
        //Todos deben ser privados para el exterior pero las clases derivadas deben poder verlos,
        //aplicar la visibilidad correspondiente.
        //nombreReal, nombrePersonaje, lugarOrigen: son del tipo string.
        //habilidades: es del tipo List<string> 
        protected int id;
        protected string nombreReal;
        protected string nombrePersonaje;
        protected string lugarDeOrigen;
        protected List<string> habilidades;


        //Constructores:
        //Tiene dos constructores de instancia, uno público y el otro privado.

        //Ctor privado: solo se encarga de crear una nueva instancia de la lista y no recibe parámetros.
        private Personaje()
        {
            this.habilidades = new List<string>();
        }
        //Ctor público: recibe parámetros y se encarga de darle valores a todos los atributos MENOS A LA LISTA,
        //no olvidar llamar al ctor privado.
        public Personaje(string nombreReal, string nombrePersonaje, string lugarDeOrigen) : this()
        {
            this.nombreReal = nombreReal;
            this.nombrePersonaje = nombrePersonaje;
            this.lugarDeOrigen = lugarDeOrigen;


        }
        //public int Id { get => id; set => id = value; }
        public string NombrePersonaje { get => nombrePersonaje; }
        //Propiedades:

        //Todas son públicas y de solo lectura.      

        //LugarDeOrigen, NombreReal: retornan el valor de dicho atributo.
        public string NombreReal { get => nombreReal; }
        public string LugarDeOrigen { get => lugarDeOrigen; }

        //Descripcion: retorna el resultado del método MostrarDescripcion.
        public string Descripcion { get => this.MostrarDescripcion(); }

        //Habilidades: debe retornar un solo string con todas las habilidades concatenadas y separadas por una coma.
        public string Habilidades
        {
            get
            {
                string valores = string.Empty;
                for (int i = 0; i < this.habilidades.Count; i++)
                {
                    valores += this.habilidades[i];
                    if (i < this.habilidades.Count - 1)
                    {
                        valores += " , ";
                    }
                }
                return valores;
            }
        }
        public string Tipo { get => this.GetType().Name; }
        //Métodos:

        //SetHabilidad: no retorna nada, es público y recibe un parámetro del tipo string que debe agregar
        //a la lista.
        public void SetHabilidad(string habilidad)
        {
            this.habilidades.Add(habilidad); // Add(List<habilidad>():)

        }
        ////Metodo para ver si una lista tiene valores
        //public bool ListaConValores()
        //{
        //    return this.habilidades.Count > 0;  
        //}
        //MostrarDescripcion: método abstracto, no visible para el exterior pero si en las clases derivadas,
        //debe retornar un string.
        protected abstract string MostrarDescripcion();

        //En la clase personaje: Sobreescribir el método equals() y dos personajes solo serán iguales
        //si coincide su nombreReal y nombrePersonaje.
        public override bool Equals(object? obj) //Hecho en clase
        {
            Personaje personaje = obj as Personaje;

            return personaje is not null &&
              personaje.nombreReal == this.nombreReal &&
              this.nombrePersonaje == personaje.nombrePersonaje;

        }
        public void CargarHabilidadesDesdeString(string habilidades)
        {
            this.habilidades.AddRange(habilidades.Split(", "));
        }
        public override string ToString()
        {
            return $"id:{id} - nombre personaje: {nombrePersonaje} - nombre real: {nombreReal} -tipo: {this.GetType().Name}";
        }
        public void SetID(int id) 
        {
            this.id = id;
        }
        public int GetId() 
        {
            return this.id;
        }
    }
}
//public override bool Equals(object personaje) //Forma corta del metodo Equals
//{
//    Personaje personajeComparar = personaje as Personaje;

//    return personajeComparar is not null &&
//      this.nombreReal == personajeComparar.nombreReal &&
//      this.nombrePersonaje == personajeComparar.nombrePersonaje;
//}

//public override bool Equals(object? obj) //Forma larga metodo Equals
//{
//    bool esIgual = false;
//    //ver si el objeto existe y si es del tipo personaje
//    if (obj is not null && obj.GetType().Name == typeof(Personaje).Name)
//    {

//        Personaje personaje = (Personaje)obj;
//        //comparar si los campos q vamos a utilizar son los correctos
//        esIgual = this.nombreReal == personaje.nombreReal && this.nombrePersonaje == personaje.nombrePersonaje;
//    }
//    return esIgual;

//}
