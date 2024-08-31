using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDePersonajes
{
    public class Villano : Personaje
    {
        //Clase Villano:
        //Hereda de Personaje.
        private string planMalvado;//Atributo:
                                   //planMalvado: atributo propio, es del tipo string, no debe ser visible al exterior.
                                   //Constructor:
                                   //Tiene un único constructor público, parametrizado y de instancia que da valores a todos los atributos.
        public Villano( string nombreReal, string nombrePersonaje, string lugarDeOrigen, string planMalvado)
            : base( nombreReal, nombrePersonaje, lugarDeOrigen)
        {
            this.planMalvado = planMalvado;
        }
        public string PlanMalvado { get => planMalvado; }
        //Método:
        //MostrarDescripcion: debe implementar dicho método y retornar un string con la siguiente
        //leyenda “{nombrePersonaje} es un villano con un plan malvado de:  { planMalvado}”.
        protected override string MostrarDescripcion()
        {
            return $"{nombrePersonaje} es un villano con un plan malvado de: {planMalvado}";
        }
        
        public override string ToString()
        {
            return base.ToString() + $" con el plan malvado: {planMalvado}";
        }
    }
}




