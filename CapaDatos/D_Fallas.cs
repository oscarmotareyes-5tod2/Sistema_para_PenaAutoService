using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D_Fallas
    {
        public void InsertarFalla(string descripcion)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarFalla", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarFallas()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarFallas", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public void ActualizarFalla(int idFalla, string descripcion)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarFalla", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdFalla", idFalla);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarFalla(int idFalla)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarFalla", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdFalla", idFalla);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}