using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_canciones.Model
{
    public class cancion_parte
    {
        public int id { get; set; }
        public int idCancion { get; set; }
        public int idParte { get; set; }

        public cancion_parte()
        {

        }

        public cancion_parte(int id)
        {
            this.id = id;
        }
        public cancion_parte(int idCancion, int idParte)
        {

            this.idCancion = idCancion;
            this.idParte = idParte;
        }
    }
}
