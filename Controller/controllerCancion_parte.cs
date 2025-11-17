using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_de_canciones.DAO;
using Lista_de_canciones.Model;

namespace Lista_de_canciones.Controller
{
    public class controllerCancion_parte
    {
        // Llamo a una instancia del DAO de cancion_parte
        DAOCancion_parte oDAOCancion_parte = DAOCancion_parte.GetDAOCancion_parte();

        //SINGLENTON
        private static controllerCancion_parte instanciaDeControllerCancion_parte;
        private controllerCancion_parte()
        {
        }
        public static controllerCancion_parte GetControllerParte_Compas()

        {
            if (instanciaDeControllerCancion_parte == null)
            {
                instanciaDeControllerCancion_parte = new controllerCancion_parte();
            }
            return instanciaDeControllerCancion_parte;
        }


        // CRUD
        public void crear(int idCancion, int idParte)
        {
            cancion_parte oCancion_parte = new cancion_parte(idCancion, idParte);
            oDAOCancion_parte.crear(oCancion_parte);
        }

        public void modificar()
        {
        }

        public void eliminarPorIdCancion(int id)
        {
            cancion_parte oCancion_parte = new cancion_parte(id);
            oDAOCancion_parte.eliminarPorIdCancion(oCancion_parte);
        }

        public void buscarTodos()
        {

        }
    }
}
