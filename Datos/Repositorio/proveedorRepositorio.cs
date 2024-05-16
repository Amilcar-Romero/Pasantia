using System;
using System.Data;
using System.Data.SqlClient;

namespace San_jose.Datos.Repositorio
{
    internal class ProveedorRepositorio : Conexion
    {
        public bool AgregarProveedor(string nombre, string nit, string correo, string telefono, string direccion, bool estado)
        {
            SqlCommand cmd = new SqlCommand("AgregarProveedor", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_proveedor", nombre);
            cmd.Parameters.AddWithValue("@nit_proveedor", nit);
            cmd.Parameters.AddWithValue("@correo_proveedor", correo);
            cmd.Parameters.AddWithValue("@telefono_proveedor", telefono);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@estado", estado);

            int rowsAffected = cmd.ExecuteNonQuery();
            CerrarConexion();

            return rowsAffected > 0;
        }

        public bool ActualizarProveedor(int id, string nombre, string nit, string correo, string telefono, string direccion, bool estado)
        {
            SqlCommand cmd = new SqlCommand("ActualizarProveedor", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_proveedor", id);
            cmd.Parameters.AddWithValue("@nombre_proveedor", nombre);
            cmd.Parameters.AddWithValue("@nit_proveedor", nit);
            cmd.Parameters.AddWithValue("@correo_proveedor", correo);
            cmd.Parameters.AddWithValue("@telefono_proveedor", telefono);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@estado", estado);

            int rowsAffected = cmd.ExecuteNonQuery();
            CerrarConexion();

            return rowsAffected > 0;
        }

        public bool EliminarProveedor(int id)
        {
            SqlCommand cmd = new SqlCommand("EliminarProveedor", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_proveedor", id);

            int rowsAffected = cmd.ExecuteNonQuery();
            CerrarConexion();

            return rowsAffected > 0;
        }
    }
}
