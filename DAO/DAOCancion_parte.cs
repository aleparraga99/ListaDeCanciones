using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_de_canciones.Model;
using Lista_de_canciones.Conexion;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Lista_de_canciones.DAO
{
    public class DAOCancion_parte
    {

        //SINGLENTON
        private static DAOCancion_parte instanciaDeDAOCancion_parte;
        private DAOCancion_parte()
        {
        }
        public static DAOCancion_parte GetDAOCancion_parte()

        {
            if (instanciaDeDAOCancion_parte == null)
            {
                instanciaDeDAOCancion_parte = new DAOCancion_parte();
            }
            return instanciaDeDAOCancion_parte;
        }

        // CRUD
        public void crear(cancion_parte oCancion_parte)
        {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "INSERT INTO Canciones_Partes (id_cancion, id_parte) VALUES (@id_cancion, @id_parte);";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                comando.Parameters.AddWithValue("@id_cancion", oCancion_parte.idCancion);
                comando.Parameters.AddWithValue("@id_parte", oCancion_parte.idParte);
                comando.ExecuteNonQuery();

            }
        }

        public void modificar()
        {
        }

        public void eliminarPorIdCancion(cancion_parte oCancion_parte)
        {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "DELETE FROM Canciones_Partes WHERE id_cancion = (@idCancion);";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                comando.Parameters.AddWithValue("@idCancion", oCancion_parte.id);
                comando.ExecuteNonQuery();

            }

        }

        public void buscarTodos()
        {

        }
    }
}
