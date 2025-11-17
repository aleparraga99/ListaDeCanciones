using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_de_canciones.DAO;
using Lista_de_canciones.Model;

namespace Lista_de_canciones.Controller
{
    public class controllerCompas
    {

        // Declaro una instancia de DAOCompas
        DAOCompas oDAOCompas = DAOCompas.GetDAOCompas();

        //SINGLENTON
        private static controllerCompas instanciaDeControllerCompas;
        private controllerCompas()
        {
        }
        public static controllerCompas GetControllerCompas()

        {
            if (instanciaDeControllerCompas == null)
            {
                instanciaDeControllerCompas = new controllerCompas();
            }
            return instanciaDeControllerCompas;
        }


        // CRUD

        public int crear(int numero) {
            compas oCompas = new compas(numero);
            int idGenerado = oDAOCompas.crear(numero);
            return idGenerado;
        }

        public void modificar(acorde oAcorde) {

            compas oCompas = new compas(oAcorde);
            oDAOCompas.modificar(oCompas);
        }

        public void buscarPorId(int idCancionActual, int idBuscado) {

           
        }
        public List<int> buscarNumerosDeCompases(int idParte) {

            List<int> numerosDeCompases = oDAOCompas.buscarNumerosDeCompases(idParte);
            return numerosDeCompases;
        }

        public List<compas> buscarCompasesYacordes(int idParte) {
            List<compas> compases = oDAOCompas.buscarCompasesYAcordes(idParte);
            return compases;
        }

        public void eliminar(int id) {
            compas oCompas = new compas(id);
            oDAOCompas.eliminar(oCompas);
        }
    }
}
