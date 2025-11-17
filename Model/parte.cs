using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_canciones.Model
{
    public class parte
    {
        // Atributos
        public int id { get; set; }
        public string nombre { get; set; }
        public int cantCompases { get; set; }
        public List<compas> compases { get; set; }


        // Constructores
        public parte() { 
        }

        public parte(int id)
        {
            this.id = id;
        }

        public parte(string nombre, int cantCompases) {

            this.nombre = nombre;
            this.cantCompases = cantCompases;
        }

        public parte(string nombre, int cantCompases, List<compas> compases) {

            this.nombre = nombre;
            this.cantCompases = cantCompases;
            this.compases = compases;
        }
        
      
    }
}
