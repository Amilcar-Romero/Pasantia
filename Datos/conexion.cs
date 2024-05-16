using System;
using System.Data.SqlClient;

namespace San_jose.Datos
{
    public class Conexion
    {
        protected SqlConnection connection;
        string connectionString = "Data Source=PCLAB614;Initial Catalog=minisup;Integrated Security=True";

        public Conexion()
        {
            try
            {
                connection = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al establecer la conexión: " + ex.Message);
            }
        }

        public SqlConnection AbrirConexion()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public SqlConnection CerrarConexion()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }
}
