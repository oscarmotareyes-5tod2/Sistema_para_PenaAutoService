using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N_Fallas
    {
        private D_Fallas datos = new D_Fallas();

        public void InsertarFalla(string descripcion)
        {
            datos.InsertarFalla(descripcion);
        }

        public DataTable ListarFallas()
        {
            return datos.ListarFallas();
        }

        public void ActualizarFalla(int idFalla, string descripcion)
        {
            datos.ActualizarFalla(idFalla, descripcion);
        }

        public void EliminarFalla(int idFalla)
        {
            datos.EliminarFalla(idFalla);
        }
    }
}