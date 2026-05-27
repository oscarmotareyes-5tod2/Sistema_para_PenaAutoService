using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_DetalleOrden
    {
        public void InsertarDetalleOrden(int idOrden, int idFalla, int cantidad, string tipoItem)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarDetalleOrden", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdOrden", idOrden);
                cmd.Parameters.AddWithValue("@IdFalla", idFalla);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@TipoItem", tipoItem);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarDetalleOrden()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarDetalleOrden", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public void ActualizarDetalleOrden(int idDetalle, int idOrden, int idFalla, int cantidad, string tipoItem)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarDetalleOrden", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdDetalle", idDetalle);
                cmd.Parameters.AddWithValue("@IdOrden", idOrden);
                cmd.Parameters.AddWithValue("@IdFalla", idFalla);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@TipoItem", tipoItem);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarDetalleOrden(int idDetalle)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarDetalleOrden", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdDetalle", idDetalle);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
