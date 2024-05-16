using System;
using System.Collections.Generic;
using System.Data;

namespace San_jose.Negocio
{
    internal class Nusuario
    {
        private Datos.Repositorio.UsuarioRepositorio usuarioRepo = new Datos.Repositorio.UsuarioRepositorio();

        public bool AgregarUsuario(string nombre, string apellido, string carnet, string correo, string clave, int idRol, bool estado)
        {
            try
            {
                return usuarioRepo.AgregarUsuario(nombre, apellido, carnet, correo, clave, idRol, estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar usuario: " + ex.Message);
                return false;
            }
        }

        public bool ActualizarUsuario(int id, string nombre, string apellido, string carnet, string correo, string contraseña, int idRol, bool estado)
        {
            try
            {
                return usuarioRepo.ActualizarUsuario(id, nombre, apellido, carnet, correo, contraseña, idRol, estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar usuario: " + ex.Message);
                return false;
            }
        }


        public bool CambiarContraseña(int id, string nuevaClave)
        {
            try
            {
                return usuarioRepo.CambiarContraseña(id, nuevaClave);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cambiar la contraseña del usuario: " + ex.Message);
                return false;
            }
        }



        public List<string> ObtenerTodosRoles()
        {
            try
            {
                DataTable dtRoles = usuarioRepo.ObtenerTodosRoles();
                List<string> roles = new List<string>();

                foreach (DataRow row in dtRoles.Rows)
                {
                    roles.Add(row["nombre_rol"].ToString());
                }

                return roles;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener todos los roles: " + ex.Message);
                return null;
            }
        }
    }
}
