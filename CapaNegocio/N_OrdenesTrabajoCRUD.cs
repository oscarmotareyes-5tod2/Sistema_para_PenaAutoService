using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_OrdenesTrabajoCRUD
    {
        D_OrdenesTrabajo datos = new D_OrdenesTrabajo();

        public void Insertar(string estado, int idVehiculo, int idEmpleado)
        {
            datos.Insertar(estado, idVehiculo, idEmpleado);
        }

        public DataTable Listar()
        {
            return datos.Listar();
        }

        public void Actualizar(int idOrden, string estado, int idVehiculo, int idEmpleado)
        {
            datos.Actualizar(idOrden, estado, idVehiculo, idEmpleado);
        }

        public void Eliminar(int idOrden)
        {
            datos.Eliminar(idOrden);
        }
    }
}
