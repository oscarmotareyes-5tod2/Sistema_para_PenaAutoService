using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Vehiculos
    {
        D_Vehiculos datos = new D_Vehiculos();
        public DataTable ListarVehiculosDashboard()
        {
            return datos.ListarVehiculosDashboard();
        }

        public DataTable ListarVehiculosPorEstado(string estado)
        {
            return datos.ListarVehiculosPorEstado(estado);
        }

        public DataTable BuscarVehiculos(string buscar)
        {
            D_Vehiculos obj = new D_Vehiculos();

            return obj.BuscarVehiculos(buscar);
        }
    }
}
