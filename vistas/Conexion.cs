using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace vistas
{
    public class Conexion
    {
        private static string uriConexion = "Data Source=localhost; " +
            "Initial Catalog= spotifyBD;" +
            "User=sa;" +
            "Password=root";
        private static SqlConnection connection;


        public static SqlConnection getConexion()
        {
            if (connection == null)
            {
                try
                {

                    connection = new SqlConnection(uriConexion);
                    connection.Open();
                    connection.Close();
                }
                catch
                {
                    connection = null;
                }
            }
            return connection;
        }
        
    }
}
