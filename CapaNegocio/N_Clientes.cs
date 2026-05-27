using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N_Clientes
    {
        private D_Cliente datos = new D_Cliente();

        public void InsertarCliente(string nombre, string telefono, string correo, string direccion)
        {
            datos.InsertarCliente(nombre, telefono, correo, direccion);
        }

        public DataTable ListarClientes()
        {
            return datos.ListarClientes();
        }

        public void ActualizarCliente(int idCliente, string nombre, string telefono, string correo, string direccion)
        {
            datos.ActualizarCliente(idCliente, nombre, telefono, correo, direccion);
        }

        public void EliminarCliente(int idCliente)
        {
            datos.EliminarCliente(idCliente);
        }
    }
}