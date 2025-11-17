using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_de_canciones.Conexion;
using Lista_de_canciones.Controller;
using Lista_de_canciones.Model;
using Microsoft.Data.SqlClient;

namespace Lista_de_canciones.DAO
{
    public class DAOParte_compas
    {

        //SINGLENTON
        private static DAOParte_compas instanciaDeDAOParte_compas;
        private DAOParte_compas()
        {
        }
        public static DAOParte_compas GetDAOParte_Compas()

        {
            if (instanciaDeDAOParte_compas == null)
            {
                instanciaDeDAOParte_compas = new DAOParte_compas();
            }
            return instanciaDeDAOParte_compas;
        }

        // CRUD
        public void crear(parte_compas oParte_compas)
        {
            using (SqlConnection conexion = BDSSMSListaDeCanciones.obtenerConexion())
            {
                string query = "INSERT INTO Partes_Compases (id_parte, id_compas) VALUES (@id_parte, @id_compas);";
                SqlCommand comando = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                comando.Parameters.AddWithValue("@id_parte", oParte_compas.idParte);
                comando.Parameters.AddWithValue("@id_compas", oParte_compas.idCompas);
                comando.ExecuteNonQuery();

            }
        }

        public void modificar()
        {
        }

        public void eliminar(int idParte)
        {

        }

        public void buscarTodos()
        {

        }
    }
}
