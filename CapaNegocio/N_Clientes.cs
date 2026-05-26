using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Clientes
    {
        D_Cliente datos = new D_Cliente();

        public void Insertar(string nombre, int telefono, string correo, string direccion)
        {
            datos.Insertar(nombre, telefono, correo, direccion);
        }

        public DataTable Listar()
        {
            return datos.Listar();
        }

        public void Actualizar(int idCliente, string nombre, string telefono, string correo, string direccion)
        {
            datos.Actualizar(idCliente, nombre, telefono, correo, direccion);
        }

        public void Eliminar(int idCliente)
        {
            datos.Eliminar(idCliente);
        }
    }
}
