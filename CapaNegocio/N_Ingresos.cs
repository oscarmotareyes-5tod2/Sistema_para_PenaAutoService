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
    public class N_Ingresos
    {
      D_Ingresos datos =new D_Ingresos();
      public void RegistrarIngresoCompleto( E_Ingreso ingreso)
      {
        datos.RegistrarIngresoCompleto(ingreso);
      }
        public DataTable ListarVehiculosIngresados()
        {
            return datos.ListarVehiculosIngresados();
        }

    }    
}
