using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_de_canciones.DAO;
using Lista_de_canciones.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lista_de_canciones.Controller
{
    public class controllerParte
    {
        // Obtengo una instancia de DAOParte
        DAOParte oDAOParte = DAOParte.GetDAOParte();

        //SINGLENTON
        private static controllerParte instanciaDeControllerParte;
        private controllerParte()
        {
        }
        public static controllerParte GetControllerParte()

        {
            if (instanciaDeControllerParte == null)
            {
                instanciaDeControllerParte = new controllerParte();
            }
            return instanciaDeControllerParte;
        }

        //CRUD

        public int crear(string nombre, int compases)
        {
            parte oParte = new parte(nombre, compases);
            int idGenerado =  oDAOParte.crear(oParte);
            return idGenerado;
        }


        public void modificar(string nombre, int cantCompases)
        {
            parte oParte = new parte(nombre, cantCompases);
            oDAOParte.modificar(oParte);
        }

        public List<string> cargarPartesComboBox(int idCancionActual) {
            List<string> partesComboBox = oDAOParte.cargarPartesComboBox(idCancionActual);
            return partesComboBox;
        }

        public List<parte> buscarPartesPorIdCancion(int idCancionActual)
        {
            List<parte> listaDePartes = oDAOParte.buscarPartesPorIdCancion(idCancionActual);
            return listaDePartes;
        }

        public void eliminar(int id)
        {
            parte oParte = new parte(id);
            oDAOParte.eliminar(oParte);

        }
    
    }
}
