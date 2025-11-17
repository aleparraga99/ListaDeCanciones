using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_de_canciones.DAO;
using Lista_de_canciones.Model;

namespace Lista_de_canciones.Controller
{
    public class controllerParte_compas
    {
        // Llamo a una instancia del DAO de parte_compas
        DAOParte_compas oDAOParte_compas = DAOParte_compas.GetDAOParte_Compas();

        //SINGLENTON
        private static controllerParte_compas instanciaDeControllerParte_compas;
        private controllerParte_compas()
        {
        }
        public static controllerParte_compas GetControllerParte_Compas()

        {
            if (instanciaDeControllerParte_compas == null)
            {
                instanciaDeControllerParte_compas = new controllerParte_compas();
            }
            return instanciaDeControllerParte_compas;
        }


        // CRUD
        public void crear(int idParte, int idCompas) {

            parte_compas oParte_Compas = new parte_compas(idParte, idCompas);
            oDAOParte_compas.crear(oParte_Compas);
        }

        public void modificar() {
        }

        public void eliminar(int idParte) {

            oDAOParte_compas.eliminar(idParte);
        }

        public void buscarTodos(){

        }

    }
}
