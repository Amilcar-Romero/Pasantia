using System;

namespace San_jose.Negocio
{
    internal class Nproveedor
    {
        private Datos.Repositorio.ProveedorRepositorio proveedorRepo = new Datos.Repositorio.ProveedorRepositorio();

        public bool AgregarProveedor(string nombre, string nit, string correo, string telefono, string direccion, bool estado)
        {
            try
            {
                return proveedorRepo.AgregarProveedor(nombre, nit, correo, telefono, direccion, estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar proveedor: " + ex.Message);
                return false;
            }
        }

        public bool ActualizarProveedor(int id, string nombre, string nit, string correo, string telefono, string direccion, bool estado)
        {
            try
            {
                return proveedorRepo.ActualizarProveedor(id, nombre, nit, correo, telefono, direccion, estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar proveedor: " + ex.Message);
                return false;
            }
        }

        public bool EliminarProveedor(int id)
        {
            try
            {
                return proveedorRepo.EliminarProveedor(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar proveedor: " + ex.Message);
                return false;
            }
        }
    }
}
