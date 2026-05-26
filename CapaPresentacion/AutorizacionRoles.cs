using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    /// <summary>
    /// Clase para gestionar la autorización y permisos según el rol del usuario
    /// </summary>
    public static class AutorizacionRoles
    {
        // Definir constantes de roles
        public const int ROL_ADMINISTRADOR = 1;
        public const int ROL_RECEPCIONISTA = 2;
        public const int ROL_MECANICO = 3;

        public const string NOMBRE_ADMINISTRADOR = "Administrador";
        public const string NOMBRE_RECEPCIONISTA = "Recepcionista";
        public const string NOMBRE_MECANICO = "Mecanico";

        /// <summary>
        /// Obtiene el nombre del rol basado en su ID
        /// </summary>
        public static string ObtenerNombreRol(int idRol)
        {
            switch (idRol)
            {
                case ROL_ADMINISTRADOR:
                    return NOMBRE_ADMINISTRADOR;
                case ROL_RECEPCIONISTA:
                    return NOMBRE_RECEPCIONISTA;
                case ROL_MECANICO:
                    return NOMBRE_MECANICO;
                default:
                    return "Desconocido";
            }
        }

        /// <summary>
        /// Verifica si el rol actual tiene acceso a un módulo específico
        /// </summary>
        public static bool TieneAcceso(int idRol, string modulo)
        {
            switch (idRol)
            {
                case ROL_ADMINISTRADOR:
                    // Administrador tiene acceso a TODO
                    return true;

                case ROL_RECEPCIONISTA:
                    // Recepcionista puede acceder a: Dashboard, Clientes, Órdenes, Reportes
                    return modulo == "Dashboard" || 
                           modulo == "Clientes" || 
                           modulo == "Ordenes" || 
                           modulo == "Reportes" || 
                           modulo == "Perfil";

                case ROL_MECANICO:
                    // Mecánico puede acceder a: Dashboard, Órdenes asignadas, Vehículos, Perfil
                    return modulo == "Dashboard" || 
                           modulo == "Ordenes" || 
                           modulo == "Vehiculos" || 
                           modulo == "Perfil";

                default:
                    return false;
            }
        }

        /// <summary>
        /// Obtiene los módulos disponibles para un rol
        /// </summary>
        public static List<string> ObtenerModulosDisponibles(int idRol)
        {
            List<string> modulos = new List<string>();

            switch (idRol)
            {
                case ROL_ADMINISTRADOR:
                    modulos.AddRange(new[] { 
                        "Dashboard", 
                        "Clientes", 
                        "Ordenes", 
                        "Vehiculos", 
                        "Usuarios", 
                        "Reportes", 
                        "Configuracion", 
                        "Perfil" 
                    });
                    break;

                case ROL_RECEPCIONISTA:
                    modulos.AddRange(new[] { 
                        "Dashboard", 
                        "Clientes", 
                        "Ordenes", 
                        "Reportes", 
                        "Perfil" 
                    });
                    break;

                case ROL_MECANICO:
                    modulos.AddRange(new[] { 
                        "Dashboard", 
                        "Ordenes", 
                        "Vehiculos", 
                        "Perfil" 
                    });
                    break;
            }

            return modulos;
        }

        /// <summary>
        /// Verifica si el usuario tiene acceso a una acción específica
        /// </summary>
        public static bool TieneAccesoAccion(int idRol, string accion)
        {
            switch (idRol)
            {
                case ROL_ADMINISTRADOR:
                    // Administrador puede hacer TODO
                    return true;

                case ROL_RECEPCIONISTA:
                    // Recepcionista puede: crear, editar órdenes, consultar clientes, ver reportes
                    return accion == "CrearOrden" || 
                           accion == "EditarOrden" || 
                           accion == "ConsultarClientes" || 
                           accion == "VerReportes" || 
                           accion == "EditarPerfil";

                case ROL_MECANICO:
                    // Mecánico puede: ver órdenes asignadas, actualizar estado, ver vehículos
                    return accion == "VerOrdenes" || 
                           accion == "ActualizarEstadoOrden" || 
                           accion == "VerVehiculos" || 
                           accion == "EditarPerfil";

                default:
                    return false;
            }
        }

        /// <summary>
        /// Obtiene una descripción del rol
        /// </summary>
        public static string ObtenerDescripcionRol(int idRol)
        {
            switch (idRol)
            {
                case ROL_ADMINISTRADOR:
                    return "Administrador: Acceso completo al sistema. Puede gestionar usuarios, configuración y todos los módulos.";

                case ROL_RECEPCIONISTA:
                    return "Recepcionista: Puede gestionar clientes, crear órdenes de trabajo y generar reportes.";

                case ROL_MECANICO:
                    return "Mecanico: Puede ver órdenes asignadas, actualizar su estado y consultar información de vehículos.";

                default:
                    return "Rol desconocido";
            }
        }
    }
}
