using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_OrdenTrabajo
    {
        public int IdOrden { get; set; }

        public DateTime Fecha { get; set; }

        public string Estado { get; set; }

        public int IdVehiculo { get; set; }

        public int IdEmpleado { get; set; }
    }
}
