using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N_Empleados
    {
        private D_Empleados datos = new D_Empleados();

        public void InsertarEmpleado(string nombre, string telefono, string cargo, string especialidad)
        {
            datos.InsertarEmpleado(nombre, telefono, cargo, especialidad);
        }

        public DataTable ListarEmpleados()
        {
            return datos.ListarEmpleados();
        }

        public void ActualizarEmpleado(int idEmpleado, string nombre, string telefono, string cargo, string especialidad)
        {
            datos.ActualizarEmpleado(idEmpleado, nombre, telefono, cargo, especialidad);
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            datos.EliminarEmpleado(idEmpleado);
        }
    }
}