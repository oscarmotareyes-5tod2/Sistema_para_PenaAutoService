using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Usuarios
    {
        public int IdUsuario { get; set; }

        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public bool Activo { get; set; }

        public int IdRol { get; set; }
    }
}
