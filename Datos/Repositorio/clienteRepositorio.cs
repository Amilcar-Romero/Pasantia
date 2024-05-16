using System;
using System.Data;
using System.Data.SqlClient;

namespace San_jose.Datos.Repositorio
{
    internal class clienteRepositorio : Conexion
    {
        public bool AgregarCliente(string nombre, string apellido, string carnet, string telefono, string correo, bool estado)
        {
            SqlCommand cmd = new SqlCommand("AgregarCliente", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_cliente", nombre);
            cmd.Parameters.AddWithValue("@apellido_cliente", apellido);
            cmd.Parameters.AddWithValue("@carnet_cliente", carnet);
            cmd.Parameters.AddWithValue("@telefono_cliente", telefono);
            cmd.Parameters.AddWithValue("@correo_cliente", correo);
            cmd.Parameters.AddWithValue("@estado", estado);

            int rowsAffected = cmd.ExecuteNonQuery();
            CerrarConexion();

            return rowsAffected > 0;
        }

        public bool ActualizarCliente(int id, string nombre, string apellido, string carnet, string telefono, string correo, bool estado)
        {
            SqlCommand cmd = new SqlCommand("ActualizarCliente", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_cliente", id);
            cmd.Parameters.AddWithValue("@nombre_cliente", nombre);
            cmd.Parameters.AddWithValue("@apellido_cliente", apellido);
            cmd.Parameters.AddWithValue("@carnet_cliente", carnet);
            cmd.Parameters.AddWithValue("@telefono_cliente", telefono);
            cmd.Parameters.AddWithValue("@correo_cliente", correo);
            cmd.Parameters.AddWithValue("@estado", estado);

            int rowsAffected = cmd.ExecuteNonQuery();
            CerrarConexion();

            return rowsAffected > 0;
        }

        public bool EliminarCliente(int id)
        {
            SqlCommand cmd = new SqlCommand("EliminarCliente", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_cliente", id);

            int rowsAffected = cmd.ExecuteNonQuery();
            CerrarConexion();

            return rowsAffected > 0;
        }
    }
}
