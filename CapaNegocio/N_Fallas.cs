using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Fallas
    {
        D_Fallas datos = new D_Fallas();

        public void Insertar(string descripcion)
        {
            datos.Insertar(descripcion);
        }

        public DataTable Listar()
        {
            return datos.Listar();
        }

        public void Actualizar(int idFalla, string descripcion)
        {
            datos.Actualizar(idFalla, descripcion);
        }

        public void Eliminar(int idFalla)
        {
            datos.Eliminar(idFalla);
        }
    }
}
