using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_OrdenesTrabajo
    {
        D_OrdenesTrabajo datos = new D_OrdenesTrabajo();

        public int TotalPorEstado(string estado)
        {
            return datos.ObtenerTotalPorEstado(estado);
        }

        public int TotalNoEntregados()
        {
            return datos.ObtenerTotalNoEntregados();
        }
    }

}
