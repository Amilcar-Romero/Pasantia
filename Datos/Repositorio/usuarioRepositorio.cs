using System;
using System.Data;
using System.Data.SqlClient;

namespace San_jose.Datos.Repositorio
{
    internal class UsuarioRepositorio : Conexion
    {
        public bool AgregarUsuario(string nombre, string apellido, string carnet, string correo, string clave, int idRol, bool estado)
        {
            SqlCommand cmd = new SqlCommand("AgregarUsuario", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_usuario", nombre);
            cmd.Parameters.AddWithValue("@apellido_usuario", apellido);
            cmd.Parameters.AddWithValue("@carnet_usuario", carnet);
            cmd.Parameters.AddWithValue("@correo_usuario", correo);
            cmd.Parameters.AddWithValue("@clave_usuario", clave);
            cmd.Parameters.AddWithValue("@id_rol", idRol);
            cmd.Parameters.AddWithValue("@estado", estado);

            int rowsAffected = cmd.ExecuteNonQuery();
            CerrarConexion();

            return rowsAffected > 0;
        }

        public bool ActualizarUsuario(int id, string nombre, string apellido, string carnet, string correo, string contraseña, int idRol, bool estado)
        {
            SqlCommand cmd = new SqlCommand("ActualizarUsuario1", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_usuario", id);
            cmd.Parameters.AddWithValue("@nombre_usuario", nombre);
            cmd.Parameters.AddWithValue("@apellido_usuario", apellido);
            cmd.Parameters.AddWithValue("@carnet_usuario", carnet);
            cmd.Parameters.AddWithValue("@correo_usuario", correo);
            cmd.Parameters.AddWithValue("@clave_usuario", contraseña); // Agregar el parámetro de la contraseña
            cmd.Parameters.AddWithValue("@id_rol", idRol);
            cmd.Parameters.AddWithValue("@estado", estado);

            int rowsAffected = cmd.ExecuteNonQuery();
            CerrarConexion();

            return rowsAffected > 0;
        }


        public bool CambiarContraseña(int id, string nuevaClave)
        {
            SqlCommand cmd = new SqlCommand("CambiarContraseña", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_usuario", id);
            cmd.Parameters.AddWithValue("@nueva_clave", nuevaClave);

            int rowsAffected = cmd.ExecuteNonQuery();
            CerrarConexion();

            return rowsAffected > 0;
        }

        public DataTable ObtenerTodosRoles()
        {
            SqlCommand cmd = new SqlCommand("ObtenerRoles", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dtRoles = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtRoles);

            CerrarConexion();

            return dtRoles;
        }
        public int ObtenerIdRolPorNombre(string nombreRol)
        {
           
            int idRol = -1;
            // Ejemplo de consulta SQL (debes reemplazarla con la consulta real)
            string consulta = "SELECT id_rol FROM rol WHERE nombre_rol = @nombreRol";
            using (SqlCommand cmd = new SqlCommand(consulta, AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@nombreRol", nombreRol);
                object resultado = cmd.ExecuteScalar();
                if (resultado != null)
                {
                    idRol = Convert.ToInt32(resultado);
                }
            }
            CerrarConexion();
            return idRol;
        }
    
}
}
