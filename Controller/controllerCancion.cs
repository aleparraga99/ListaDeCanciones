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
    public class controllerCancion
    {
        // Llamo a la instancia de DAOCancion
        DAOCancion oDAOCancion = DAOCancion.GetDAOCancion();

        //SINGLENTON
        private static controllerCancion instanciaDeControllerCancion;
        private controllerCancion()
        {
        }
        public static controllerCancion GetControllerCancion()

        {
            if (instanciaDeControllerCancion == null)
            {
                instanciaDeControllerCancion = new controllerCancion();
            }
            return instanciaDeControllerCancion;
        }



        //CRUD

        public void crear() {
            cancion oCancion = new cancion();
            oDAOCancion.crear(oCancion);
         
        }
        public int crear(string autor, string nombre) {
            cancion oCancion = new cancion(autor, nombre);
            int nuevoId = oDAOCancion.crear(oCancion);
            return nuevoId;
        }

        public void crear(string autor, string nombre, estructura oEstructura)
        {
            cancion oCancion = new cancion(autor, nombre, oEstructura);
            oDAOCancion.crear(oCancion);

        }

        public List<cancion> buscarNombreYAutor() {
            List<cancion> canciones = oDAOCancion.buscarNombreYAutor();
            return canciones;
        }
        public void modificar(cancion oCancion) {
            oDAOCancion.modificar(oCancion);
        }
        public void modificar(string autor, string nombre, estructura oEstructura)
        {
            cancion oCancion = new cancion(autor, nombre, oEstructura);
            oDAOCancion.modificar(oCancion);
        }

        //public cancion buscarPorId(int id)
        //{
        //    cancion oCancion = new cancion(id);
        //    cancion cancionBuscada = oDAOCancion.buscarPorId(oCancion);
        //    return cancionBuscada;
        //}

        public void eliminar(int id)
        {
            cancion oCancion = new cancion(id);
            oDAOCancion.eliminar(oCancion);

        }
    }
}
