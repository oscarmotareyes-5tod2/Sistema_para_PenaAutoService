using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Usuarios
    {
        public void InsertarUsuario(E_Usuarios usuario)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd =new SqlCommand("SP_InsertarUsuario",cn);

                cmd.CommandType =CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username", usuario.Username);
                cmd.Parameters.AddWithValue("@PasswordHash", usuario.PasswordHash);
                cmd.Parameters.AddWithValue("@IdRol",usuario.IdRol);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public int ExisteUsuario(string username)
        {
            int total = 0;

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_ExisteUsuario",cn);

                cmd.CommandType =CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username",username);

                cn.Open();

                total= Convert.ToInt32(cmd.ExecuteScalar());
            }

            return total;
        }

        public DataTable ListarUsuarios()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarUsuarios",cn);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }

        public void DesactivarUsuario(int idUsuario)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd =new SqlCommand("SP_DesactivarUsuario",cn);

                cmd.CommandType =CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdUsuario",idUsuario);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable BuscarUsuarios(string buscar)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn =Conexion.ObtenerConexion())
            {
                SqlCommand cmd =new SqlCommand("SP_BuscarUsuarios",cn);

                cmd.CommandType =CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Buscar",buscar);

                SqlDataAdapter da =new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }

        public void ActualizarUsuario(E_Usuarios usuario)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd =new SqlCommand("SP_ActualizarUsuario",cn);

                cmd.CommandType =CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdUsuario",usuario.IdUsuario);

                cmd.Parameters.AddWithValue("@Username", usuario.Username);

                cmd.Parameters.AddWithValue("@PasswordHash",usuario.PasswordHash);

                cmd.Parameters.AddWithValue("@IdRol",usuario.IdRol);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }
    }
}
