using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Lista_de_canciones.Conexion;
using Lista_de_canciones.Model;
using Microsoft.Data.SqlClient;

namespace Lista_de_canciones.DAO
{
    public class DAOCancion
    {

        //SINGLENTON
        private static DAOCancion instanciaDeDAOCancion;
        private DAOCancion()
        {
        }
        public static DAOCancion GetDAOCancion()

        {
            if (instanciaDeDAOCancion == null)
            {
                instanciaDeDAOCancion = new DAOCancion();
            }
            return instanciaDeDAOCancion;
        }


        // CRUD
        public int crear(cancion oCancion)
        {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "INSERT INTO Canciones (autor, nombre) VALUES (@autor, @nombre); SELECT SCOPE_IDENTITY();";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                comando.Parameters.AddWithValue("@autor", oCancion.autor);
                comando.Parameters.AddWithValue("@nombre", oCancion.nombre);

                int nuevoId = Convert.ToInt32(comando.ExecuteScalar());
                return nuevoId;
            }
        }
        
        public List<cancion> buscarNombreYAutor()
        {

            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "SELECT c.id, c.nombre, c.autor FROM Canciones c WHERE c.nombre IS NOT NULL;";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                List<cancion> canciones = new List<cancion>();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read()) {

                    cancion oCancion = new cancion();
                    oCancion.id = Convert.ToInt32(reader["id"]);
                    oCancion.nombre = reader["nombre"].ToString();
                    oCancion.autor = reader["autor"].ToString();

                    canciones.Add(oCancion);
                }

                return canciones;
            }

        }
        public void modificar(cancion oCancion)
        {

            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "UPDATE Canciones SET autor = @autor, nombre = @nombre WHERE id = @idCancion;";

                SqlCommand comando = new SqlCommand(query, conexion);

                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                comando.Parameters.AddWithValue("@idCancion", oCancion.id);
                comando.Parameters.AddWithValue("@autor", oCancion.autor);
                comando.Parameters.AddWithValue("@nombre", oCancion.nombre);
                
                comando.ExecuteNonQuery();
            }
        }

        public void eliminar(cancion oCancion)
        {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "DELETE FROM Canciones WHERE id = (@idCancion);";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                comando.Parameters.AddWithValue("@idCancion", oCancion.id);
                comando.ExecuteNonQuery();
            }
        }
    }
}
