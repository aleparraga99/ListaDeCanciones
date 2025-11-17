using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_canciones.Model
{
    public class parte_compas
    {
        public int id { get; set; }
        public int idParte { get; set; }
        public int idCompas { get; set; }

        public parte_compas() { 
        
        }

        public parte_compas(int id) {
            this.id = id;
        }
        public parte_compas(int idParte, int idCompas) {

            this.idParte = idParte;
            this.idCompas = idCompas;
        }
    }
}
