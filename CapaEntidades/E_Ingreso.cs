using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Ingreso
    {
        // CLIENTE
        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public string Direccion { get; set; }

        // VEHICULO
        public string Placa { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Anio { get; set; }

        // ORDEN
        public int IdUsuario { get; set; }

        public string Fallas { get; set; }

        // DETALLE
        public int IdFalla { get; set; }

        public int Cantidad { get; set; }

    }
}
