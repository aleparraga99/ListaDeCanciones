using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_canciones.Model
{
    public class compas_acorde
    {
        public int id { get; set; }
        public int id_compas { get; set; }
        public int id_acorde { get; set; }


        public compas_acorde() { 
        
        }

        public compas_acorde(int id_compas, int id_acorde) {

            this.id_compas = id_compas;
            this.id_acorde = id_acorde;

        }
    }
}
