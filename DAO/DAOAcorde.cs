using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_de_canciones.Conexion;
using Lista_de_canciones.Model;
using Microsoft.Data.SqlClient;

namespace Lista_de_canciones.DAO
{
    public class DAOAcorde
    {
        //SINGLENTON
        private static DAOAcorde instanciaDeDAOAcorde;
        private DAOAcorde()
        {
        }
        public static DAOAcorde GetDAOAcorde()

        {
            if (instanciaDeDAOAcorde == null)
            {
                instanciaDeDAOAcorde = new DAOAcorde();
            }
            return instanciaDeDAOAcorde;
        }

        // CRUD
        public int crear(acorde oAcorde)
        {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "INSERT INTO Acordes (tonica, modo, extension, bajo) VALUES (@tonica,@modo, @extension, @bajo); SELECT SCOPE_IDENTITY();";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                comando.Parameters.AddWithValue("@tonica", oAcorde.tonica);
                comando.Parameters.AddWithValue("@modo", oAcorde.modo);
                comando.Parameters.AddWithValue("@extension", oAcorde.extension);
                comando.Parameters.AddWithValue("@bajo", oAcorde.bajo);
                int nuevoId = Convert.ToInt32(comando.ExecuteScalar());
                return nuevoId;
            }
        }

        public void modificar(acorde oAcorde)
        {
            // hacer consulta en la base de datos
        }

        //public acorde buscar(acorde oAcorde)
        //{
        //    // hacer consulta en la base de datos
        //}

        public void eliminar(acorde oAcordes)
        {
            // hacer consulta a la base de datos
        }

    }
}
