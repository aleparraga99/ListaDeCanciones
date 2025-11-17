using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_canciones.Model
{
    public class cancion
    {

        // Atributos
        public int id { get; set; }
        public string autor { get; set; }
        public string nombre { get; set; }
        public estructura oEstructura { get; set; } 


        // Constructores
        public cancion() { 
        }

        public cancion(int id)
        {
            this.id = id;
        }
        public cancion(string autor, string nombre) {

            this.autor = autor;
            this.nombre = nombre;
        
        }

        public cancion(int id, string autor, string nombre)
        {
            this.id = id;
            this.autor = autor;
            this.nombre = nombre;

        }
        public cancion(string autor, string nombre, estructura oEstructura)
        {

            this.autor = autor;
            this.nombre = nombre;
            this.oEstructura = oEstructura;

        }
    }
}
