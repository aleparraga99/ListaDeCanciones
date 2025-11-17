using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks.Dataflow;
using System.Diagnostics;


namespace Lista_de_canciones.Conexion
{
    public class BDSSMSListaDeCanciones
    {
        public static SqlConnection obtenerConexion()
        {
            SqlConnection conexion = new SqlConnection( "Data Source=DESKTOP-TQ8IRKU\\SQLEXPRESS;Initial Catalog=ListaDeCanciones;Integrated Security=True;TrustServerCertificate=True;"
 );

            if (conexion.State == ConnectionState.Closed)
            {
                try
                {
                    conexion.Open();
                }
                catch
                {
                   
                }
            }
            return conexion;
        }
    }
}
