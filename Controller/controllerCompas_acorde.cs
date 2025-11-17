using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_de_canciones.DAO;
using Lista_de_canciones.Model;

namespace Lista_de_canciones.Controller
{
    public class controllerCompas_acorde
    {
        // Declaro una instancia de DAOCompas
        DAOCompas_acorde oDAOCompas_acorde = DAOCompas_acorde.GetDAOCompas_acorde();

        //SINGLENTON
        private static controllerCompas_acorde instanciaDeControllerCompas_acorde;
        private controllerCompas_acorde()
        {
        }
        public static controllerCompas_acorde GetControllerCompas_acorde()

        {
            if (instanciaDeControllerCompas_acorde == null)
            {
                instanciaDeControllerCompas_acorde = new controllerCompas_acorde();
            }
            return instanciaDeControllerCompas_acorde;
        }
        //CRUD

        public void crear(int idAcorde, int idParte) {
            compas_acorde oCompas_acorde = new compas_acorde(idAcorde, idParte);
            oDAOCompas_acorde.crear(oCompas_acorde);
        }
        public void buscar()
        {
        }
        public void modificar()
        {
        }
        public void eliminar()
        {
        }
    }
}
