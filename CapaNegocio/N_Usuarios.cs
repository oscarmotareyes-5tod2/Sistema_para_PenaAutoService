using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaNegocio
{
    public class N_Usuarios
    {
        D_Usuarios datos = new D_Usuarios();

        public void InsertarUsuario(E_Usuarios usuario)
        {
            datos.InsertarUsuario(usuario);
        }

        public DataTable ListarUsuarios()
        {
            return datos.ListarUsuarios();
        }

        public DataTable BuscarUsuarios(string buscar)
        {
            return datos.BuscarUsuarios(buscar);
        }

        public void DesactivarUsuario(int idUsuario)
        {
            datos.DesactivarUsuario(idUsuario);
        }

        public void ActualizarUsuario(E_Usuarios usuario)
        {
            datos.ActualizarUsuario(usuario);
        }

        public int ExisteUsuario(string username)
        {
            return datos.ExisteUsuario(username);
        }
    }
}
