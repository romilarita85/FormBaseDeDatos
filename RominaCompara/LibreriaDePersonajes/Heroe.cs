using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDePersonajes
{
    public class Heroe : Personaje
    {
        //Clase Heroe:Hereda de Personaje.
        //Atributo:
        private string alianza;//alianza: atributo propio, es del tipo string, no debe ser visible al exterior.
        //Constructor:Tiene un único constructor público, parametrizado y de instancia que da valores a todos los atributos.

        public Heroe(string nombreReal, string nombrePersonaje, string lugarDeOrigen, string alianza)
            : base( nombreReal, nombrePersonaje, lugarDeOrigen)
        {
            this.alianza = alianza;
        }
        public string Alianza { get => alianza; }
        //Método:Descripcion: debe implementar dicho método y retornar un string con la siguiente leyenda
        //“{nombrePersonaje} es un héroe de la alianza {alianza}”.
        protected override string MostrarDescripcion()
        {
            return $"{nombrePersonaje} es un héroe de la alianza {alianza}";
        }

    }
}





