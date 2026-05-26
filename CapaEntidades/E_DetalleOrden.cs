using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_DetalleOrden
    {
        public int IdDetalle { get; set; }
        public int IdOrden { get; set; }
        public int IdFalla { get; set; }
        public int Cantidad { get; set; }
        public string TipoItem { get; set; }
    }
}
