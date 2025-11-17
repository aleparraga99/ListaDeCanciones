using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_canciones.Model
{
    public class estructura
    {

        // Atributos
        public int id { get; set; }
        public List<parte> partes {get; set;}


        // Constructores
        public estructura()
        {
        }
        public estructura(int id)
        {
            this.id = id;
        }
        public estructura(List<parte> partes) {
            this.partes = partes;
        }
    }

}
