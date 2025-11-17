using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_de_canciones.Conexion;
using Lista_de_canciones.Model;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace Lista_de_canciones.DAO
{
    public class DAOCompas
    {

        //SINGLENTON
        private static DAOCompas instanciaDeDAOCompas;
        private DAOCompas()
        {
        }
        public static DAOCompas GetDAOCompas()

        {
            if (instanciaDeDAOCompas == null)
            {
                instanciaDeDAOCompas = new DAOCompas();
            }
            return instanciaDeDAOCompas;
        }

        // CRUD

        public int crear(int numero) {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "INSERT INTO Compases (numero)  VALUES (@numero);SELECT SCOPE_IDENTITY();";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                comando.Parameters.AddWithValue("@numero", numero);

                int idGenerado = Convert.ToInt32(comando.ExecuteScalar());

                return idGenerado;

            }
        }
        public void crear(compas oCompas)
        {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "INSERT INTO Compases (acordes) VALUES (@acordes)";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                comando.Parameters.AddWithValue("@acordes", oCompas.oAcorde);
                comando.ExecuteNonQuery();
            }
        }

        public void modificar(compas oCompas)
        {
           
            // Hacer la consulta a la base de datos
        }

        public void buscarPorId(int idCancionActual,int idBuscado)
        {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "SELECT c.id FROM Compases c INNER JOIN Partes_Compases pc ON c.id = pc.id_compas INNER JOIN Partes p ON p.id = pc.id_parte INNER JOIN Canciones_Partes cp ON cp.id_parte = p.id WHERE cp.id_cancion = @idCancionActual ;";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                comando.Parameters.AddWithValue("@idCancionActual", idCancionActual);
               
            }

            }


        public List<int> buscarNumerosDeCompases(int idParte)
        {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "SELECT c.numero FROM Compases c INNER JOIN Partes_Compases p ON c.id = p.id_compas WHERE p.id_parte = @idParte;";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                comando.Parameters.AddWithValue("@idParte", idParte);

                SqlDataReader lector = comando.ExecuteReader();
                List<int> numerosDeCompases = new List<int>();

                while (lector.Read())
                {
                    int numeroCompas = (int)lector["numero"];
                    numerosDeCompases.Add(numeroCompas);
                }

                return numerosDeCompases;
            }
        }

        public List<compas> buscarCompasesYAcordes(int idParte) {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "SELECT c.id, c.numero, a.tonica, a.modo, a.extension, a.bajo FROM Compases c INNER JOIN Partes_Compases p ON c.id = p.id_compas INNER JOIN Compas_Acorde q ON q.id_compas = c.id INNER JOIN Acordes a ON a.id = q.id_acorde WHERE p.id_parte = @idParte;";

                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                comando.Parameters.AddWithValue("@idParte", idParte);

                SqlDataReader lector = comando.ExecuteReader();
                List<compas> compases = new List<compas>();

                while (lector.Read())
                {
                    string tonica = (string)lector["tonica"];
                    string modo = (string)lector["modo"];
                    string extension = (string)lector["extension"];
                    string bajo = (string)lector["bajo"];

                    acorde oAcorde = new acorde(tonica, modo, extension, bajo);

                    int id = (int)lector["id"];
                    int numero = (int)lector["numero"];

                    compas oCompas = new compas(id, numero, oAcorde);

                    compases.Add(oCompas);
                }

                return compases;
            } 
        }
        
        public void eliminar(compas oCompas)
        {
            // hacer consulta a la base de datos
        }

    }
}
