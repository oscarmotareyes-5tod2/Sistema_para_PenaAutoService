using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Empleados
    {
        D_Empleados datos = new D_Empleados();

        public void Insertar(string nombre, string telefono, string cargo, string especialidad)
        {
            datos.Insertar(nombre, telefono, cargo, especialidad);
        }

        public DataTable Listar()
        {
            return datos.Listar();
        }

        public void Actualizar(int idEmpleado, string nombre, string telefono, string cargo, string especialidad)
        {
            datos.Actualizar(idEmpleado, nombre, telefono, cargo, especialidad);
        }

        public void Eliminar(int idEmpleado)
        {
            datos.Eliminar(idEmpleado);
        }
    }
}
