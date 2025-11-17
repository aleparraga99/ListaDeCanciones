using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_de_canciones.DAO;
using Lista_de_canciones.Model;

namespace Lista_de_canciones.Controller
{
    public class controllerEstructura
    {
        // Declaro una instancia de DAOEstructura
        DAOEstructura oDAOEstructura = DAOEstructura.GetDAOEstructura();

        
        //CRUD
        public void crear(List<parte> partes)
        {
            estructura oEstructura = new estructura(partes);
            oDAOEstructura.crear(oEstructura);
        }
        public void modificar(List<parte> partes)
        {
            estructura oEstructura = new estructura(partes);
            oDAOEstructura.modificar(oEstructura);
        }

       // public estructura busca(int id)
        //{
           // estructura oEstructura = new estructura(id);
            //estructura estructuraBuscada = oDAOEstructura.buscarPorId(oEstructura);
           // return estructuraBuscada;
        //}

        public void eliminar(List<parte> partes)
        {
            estructura oEstructura = new estructura(partes);
            oDAOEstructura.eliminar(oEstructura);
        }
    }
}
