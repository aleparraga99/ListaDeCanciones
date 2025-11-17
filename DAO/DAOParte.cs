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
    public class DAOParte
    {

        //SINGLENTON
        private static DAOParte instanciaDeDAOParte;
        private DAOParte()
        {
        }
        public static DAOParte GetDAOParte()

        {
            if (instanciaDeDAOParte == null)
            {
                instanciaDeDAOParte = new DAOParte();
            }
            return instanciaDeDAOParte;
        }

        public int crear(parte oParte) 
        {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "INSERT INTO Partes (nombre, cantidadCompases) VALUES (@nombre, @cantidadCompases);SELECT SCOPE_IDENTITY();";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                comando.Parameters.AddWithValue("@nombre", oParte.nombre);
                comando.Parameters.AddWithValue("@cantidadCompases", oParte.cantCompases);
                int idGenerado = Convert.ToInt32(comando.ExecuteScalar());
                
                return idGenerado;
            }
        }
        public List<string> cargarPartesComboBox(int idCancionActual)
        {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "SELECT p.nombre FROM Partes p INNER JOIN Cancion_Partes c ON p.id = c.id_parte WHERE c.id_cancion = @idCancionActual;"; //  SELECT SCOPE_IDENTITY();
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                comando.Parameters.AddWithValue("@idCancionActual", idCancionActual);

                SqlDataReader lector = comando.ExecuteReader();
                List<string> nombreDePartes = new List<string>();

                while (lector.Read())
                {
                    string nombreParte = lector["nombre"].ToString();
                    nombreDePartes.Add(nombreParte);
                }

                return nombreDePartes;
            }
        }
        public List<parte> buscarPartesPorIdCancion(int idCancion)
        {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = @"
            SELECT p.id, p.nombre, p.cantidadCompases
            FROM Partes p
            INNER JOIN Canciones_Partes u
                ON u.id_parte = p.id
            WHERE u.id_cancion = @idCancion;
        ";

                SqlCommand comando = new SqlCommand(query, conexion);

                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();

                comando.Parameters.AddWithValue("@idCancion", idCancion);

                SqlDataReader lector = comando.ExecuteReader();

                List<parte> listaDePartes = new List<parte>();

                while (lector.Read())
                {
                    parte oParte = new parte();
                    oParte.id = Convert.ToInt32(lector["id"]);
                    oParte.nombre = lector["nombre"].ToString();
                    oParte.cantCompases = Convert.ToInt32(lector["cantidadCompases"]);

                    listaDePartes.Add(oParte);
                }

                return listaDePartes;
            }
        }

        public void modificar(parte oParte)
        {
            // hacer consulta en a la base de datos
        }

        public void eliminar(parte oParte)
        {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = @"
        DELETE FROM Partes_Compases   WHERE id_parte = @idParte;
        DELETE FROM Canciones_Partes  WHERE id_parte = @idParte;
        DELETE FROM Partes            WHERE id = @idParte;
    ";

                SqlCommand comando = new SqlCommand(query, conexion);

                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                comando.Parameters.AddWithValue("@idParte", oParte.id);
                comando.ExecuteNonQuery();
            }


        }

    }
}
