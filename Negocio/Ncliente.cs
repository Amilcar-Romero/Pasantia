using System;
using System.Data;

namespace San_jose.Negocio
{
    internal class Ncliente
    {
        private Datos.Repositorio.clienteRepositorio clienteRepo = new Datos.Repositorio.clienteRepositorio();

        public bool AgregarCliente(string nombre, string apellido, string carnet, string telefono, string correo, bool estado)
        {
            try
            {
                return clienteRepo.AgregarCliente(nombre, apellido, carnet, telefono, correo, estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar cliente: " + ex.Message);
                return false;
            }
        }

        public bool ActualizarCliente(int id, string nombre, string apellido, string carnet, string telefono, string correo, bool estado)
        {
            try
            {
                return clienteRepo.ActualizarCliente(id, nombre, apellido, carnet, telefono, correo, estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar cliente: " + ex.Message);
                return false;
            }
        }

        public bool EliminarCliente(int id)
        {
            try
            {
                return clienteRepo.EliminarCliente(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar cliente: " + ex.Message);
                return false;
            }
        }
    }
}
