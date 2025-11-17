using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_de_canciones.DAO;
using Lista_de_canciones.Model;

namespace Lista_de_canciones.Controller
{
    public class controllerAcorde
    {
        // Llamo una instancia de DAOAcorde
        DAOAcorde oDAOAcorde = DAOAcorde.GetDAOAcorde();

        //SINGLENTON
        private static controllerAcorde instanciaDeControllerAcorde;
        private controllerAcorde()
        {
        }
        public static controllerAcorde GetControllerAcorde()

        {
            if (instanciaDeControllerAcorde == null)
            {
                instanciaDeControllerAcorde = new controllerAcorde();
            }
            return instanciaDeControllerAcorde;
        }

        //CRUD
        public int crear(string tonica, string modo, string extension, string bajo)
        {
            acorde oAcorde = new acorde(tonica, modo,extension, bajo);
            int idGenerado = oDAOAcorde.crear(oAcorde);
            return idGenerado;

        }
        public void modificar(string tonica, string modo, string extension, string bajo)
        {
            acorde oAcorde = new acorde(tonica, modo, extension, bajo);
            oDAOAcorde.modificar(oAcorde);
        }

        //public acorde buscarPorId(int id)
        //{
        //    acorde oAcorde = new acorde(id);
        //    acorde acordeBuscado = oDAOAcorde.buscar(oAcorde);
        //    return acordeBuscado;
        //}

        public void eliminar(int id)
        {
            acorde oAcorde = new acorde(id);
            oDAOAcorde.eliminar(oAcorde);
        }
    }
}
