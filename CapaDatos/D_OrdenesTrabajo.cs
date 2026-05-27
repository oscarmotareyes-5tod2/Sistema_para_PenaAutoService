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
        public void InsertarOrden(string estado, int idVehiculo, int idEmpleado)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarOrden", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.Parameters.AddWithValue("@IdVehiculo", idVehiculo);
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarOrdenes()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarOrdenes", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public void ActualizarOrden(int idOrden, string estado, int idVehiculo, int idEmpleado)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarOrden", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdOrden", idOrden);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.Parameters.AddWithValue("@IdVehiculo", idVehiculo);
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarOrden(int idOrden)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarOrden", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdOrden", idOrden);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

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
