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

        public void InsertarRol(string nombreRol)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarRol", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreRol", nombreRol);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarRol(int idRol, string nombreRol)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarRol", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdRol", idRol);
                cmd.Parameters.AddWithValue("@NombreRol", nombreRol);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarRol(int idRol)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarRol", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdRol", idRol);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }
    }
}
