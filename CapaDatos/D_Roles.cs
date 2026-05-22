using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Roles
    {
        public DataTable ListarRoles()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd =new SqlCommand("sp_ListarRoles", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da =new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }
    }
}
