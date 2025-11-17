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
    public class DAOCompas_acorde
    {

        //SINGLENTON
        private static DAOCompas_acorde instanciaDeDAOCompas_acorde;
        private DAOCompas_acorde()
        {
        }
        public static DAOCompas_acorde GetDAOCompas_acorde()

        {
            if (instanciaDeDAOCompas_acorde == null)
            {
                instanciaDeDAOCompas_acorde = new DAOCompas_acorde();
            }
            return instanciaDeDAOCompas_acorde;
        }


        //CRUD

        public void crear(compas_acorde oCompas_acorde)
        {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "INSERT INTO Compas_Acorde (id_acorde, id_compas) VALUES (@id_acorde, @id_compas);";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                comando.Parameters.AddWithValue("@id_acorde", oCompas_acorde.id_acorde);
                comando.Parameters.AddWithValue("@id_compas", oCompas_acorde.id_compas);
                comando.ExecuteNonQuery();

            }
        }
        public void buscar()
        {
        }
        public void modificar()
        {
        }
        public void eliminarPorIdParte(int idParte)
        {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "DELETE FROM Partes_Compases WHERE id_parte = (@idParte);";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                comando.Parameters.AddWithValue("@idCancion", idParte);
                comando.ExecuteNonQuery();

            }
        }
    }
}
