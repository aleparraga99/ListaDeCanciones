using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_canciones.Model
{
    public class acorde
    {
        //Atributos
        public int id { get; set; }
        public string tonica { get; set; }
        public string modo { get; set; }
        public string extension { get; set; }
        public string bajo { get; set; } 


        // Constructores
        public acorde()
        {
        }

        public acorde(int id) {
            this.id = id;
        }

        public acorde(string tonica, string modo, string extension, string bajo)
        {
            this.tonica = tonica;
            this.modo = modo;
            this.extension = extension;
            this.bajo = bajo;
        }
    }
}
