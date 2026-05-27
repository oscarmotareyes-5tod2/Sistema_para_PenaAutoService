using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_OrdenesTrabajo
    {
        D_OrdenesTrabajo datos = new D_OrdenesTrabajo();

        public void InsertarOrden(string estado, int idVehiculo, int idEmpleado)
        {
            datos.InsertarOrden(estado, idVehiculo, idEmpleado);
        }

        public DataTable ListarOrdenes()
        {
            return datos.ListarOrdenes();
        }

        public void ActualizarOrden(int idOrden, string estado, int idVehiculo, int idEmpleado)
        {
            datos.ActualizarOrden(idOrden, estado, idVehiculo, idEmpleado);
        }

        public void EliminarOrden(int idOrden)
        {
            datos.EliminarOrden(idOrden);
        }

        public int ObtenerTotalPorEstado(string estado)
        {
            return datos.ObtenerTotalPorEstado(estado);
        }

        public int TotalPorEstado(string estado)
        {
            return datos.ObtenerTotalPorEstado(estado);
        }

        public int ObtenerTotalNoEntregados()
        {
            return datos.ObtenerTotalNoEntregados();
        }

        public int TotalNoEntregados()
        {
            return datos.ObtenerTotalNoEntregados();
        }
    }
}
