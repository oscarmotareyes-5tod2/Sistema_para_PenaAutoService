using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Roles
    {
        D_Roles datos =new D_Roles();

        public DataTable ListarRoles()
        {
            return datos.ListarRoles();
        }

        public void InsertarRol(string nombreRol)
        {
            datos.InsertarRol(nombreRol);
        }

        public void ActualizarRol(int idRol, string nombreRol)
        {
            datos.ActualizarRol(idRol, nombreRol);
        }

        public void EliminarRol(int idRol)
        {
            datos.EliminarRol(idRol);
        }
    }
}
