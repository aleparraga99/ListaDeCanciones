using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_de_canciones.Model;

namespace Lista_de_canciones.DAO
{
    public class DAOEstructura
    {

        //SINGLENTON
        private static DAOEstructura instanciaDeDAOEstructura;
        private DAOEstructura()
        {
        }
        public static DAOEstructura GetDAOEstructura()

        {
            if (instanciaDeDAOEstructura == null)
            {
                instanciaDeDAOEstructura = new DAOEstructura();
            }
            return instanciaDeDAOEstructura;
        }

        // CRUD

        public void crear(estructura oEstructura)
        {
            // hacer consulta en a la base de datos
            
        }
        //public estructura buscar(estructura oEstructura)
        //{
        //    // hacer consulta en a la base de datos
        //}
        public void modificar(estructura oEstructura)
        {
            // hacer consulta en a la base de datos
        }

        public void eliminar(estructura oEstructura)
        {
            // hacer consulta en a la base de datos
        }
    }
}
