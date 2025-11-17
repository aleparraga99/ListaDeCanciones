using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Lista_de_canciones.Model;

namespace Lista_de_canciones.Model
{
    public class compas
    {
        // Atributos
        public int id { get; set; }
        public acorde oAcorde { get; set; }
        public int numero { get; set; }


        // Constructores
        public compas() { 
        }

        public compas(int id) {
            this.id = id;
        }

        public compas(int id, int numero) {
            this.id = id;
            this.numero = numero;
        }
      
        public compas(acorde oAcorde) {

            this.oAcorde = oAcorde;
        }

        public compas(int id, int numero, acorde oAcorde) {
            this.id = id;
            this.numero = numero;
            this.oAcorde = oAcorde;
        }

         
    }
}
