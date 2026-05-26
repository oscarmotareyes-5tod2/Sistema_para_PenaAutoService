using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_DetalleOrdencs
    {
        D_DetalleOrdencs datos = new D_DetalleOrdencs();

        public void Insertar(int idOrden, int idFalla, int cantidad, string tipoItem)
        {
            datos.Insertar(idOrden, idFalla, cantidad, tipoItem);
        }

        public DataTable Listar()
        {
            return datos.Listar();
        }

        public void Actualizar(int idDetalle, int idOrden, int idFalla, int cantidad, string tipoItem)
        {
            datos.Actualizar(idDetalle, idOrden, idFalla, cantidad, tipoItem);
        }

        public void Eliminar(int idDetalle)
        {
            datos.Eliminar(idDetalle);
        }
    }
}
