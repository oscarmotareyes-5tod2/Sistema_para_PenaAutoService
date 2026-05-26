using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    /// <summary>
    /// Clase para mantener la sesión del usuario autenticado en la aplicación
    /// </summary>
    public static class SesionUsuario
    {
        private static E_Usuarios usuarioActual = null;
        private static string nombreRol = "";

        public static E_Usuarios UsuarioActual
        {
            get { return usuarioActual; }
            set { usuarioActual = value; }
        }

        public static string NombreRol
        {
            get { return nombreRol; }
            set { nombreRol = value; }
        }

        public static bool EstaAutenticado
        {
            get { return usuarioActual != null && usuarioActual.IdUsuario > 0; }
        }

        public static int IdRolActual
        {
            get { return usuarioActual != null ? usuarioActual.IdRol : 0; }
        }

        public static void IniciarSesion(E_Usuarios usuario, string rol)
        {
            usuarioActual = usuario;
            nombreRol = rol;
        }

        public static void CerrarSesion()
        {
            usuarioActual = null;
            nombreRol = "";
        }
    }
}
