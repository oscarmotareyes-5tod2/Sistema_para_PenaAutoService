 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_OrdenesTrabajo
    {
        public int ObtenerTotalPorEstado(string estado)
        {
            int total = 0;

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_TotalPorEstado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Estado", estado);

                cn.Open();

                total = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return total;
        }

        public int ObtenerTotalNoEntregados()
        {
            int total = 0;

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_TotalNoEntregados", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                total = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return total;
        }
    }
}
