using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_DetalleOrden
    {
        D_DetalleOrden datos = new D_DetalleOrden();

        public void InsertarDetalleOrden(int idOrden, int idFalla, int cantidad, string tipoItem)
        {
            datos.InsertarDetalleOrden(idOrden, idFalla, cantidad, tipoItem);
        }

        public DataTable ListarDetalleOrden()
        {
            return datos.ListarDetalleOrden();
        }

        public void ActualizarDetalleOrden(int idDetalle, int idOrden, int idFalla, int cantidad, string tipoItem)
        {
            datos.ActualizarDetalleOrden(idDetalle, idOrden, idFalla, cantidad, tipoItem);
        }

        public void EliminarDetalleOrden(int idDetalle)
        {
            datos.EliminarDetalleOrden(idDetalle);
        }
    }
}
