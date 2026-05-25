using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Configuracion
    {
        D_Configuracion datos = new D_Configuracion();

        public void GuardarConfiguracion(E_Configuracion config)
        {
            datos.GuardarConfiguracion(config);
        }

        public DataTable ObtenerConfiguracion()
        {
            return datos.ObtenerConfiguracion();
        }

        public void CrearBackup(string ruta)
        {
            datos.CrearBackup(ruta);
        }

        public void RestaurarBackup(string ruta)
        {
            datos.RestaurarBackup(ruta);
        }
    }
}
