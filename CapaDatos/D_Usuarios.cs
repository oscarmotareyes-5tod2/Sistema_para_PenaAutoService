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
                SqlCommand cmd =new SqlCommand("sp_InsertarUsuario",cn);

                cmd.CommandType =CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username", usuario.Username);
                cmd.Parameters.AddWithValue("@PasswordHash", usuario.PasswordHash);
                cmd.Parameters.AddWithValue("@Activo", usuario.Activo);
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
                SqlCommand cmd =new SqlCommand("sp_ActualizarUsuario",cn);

                cmd.CommandType =CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdUsuario",usuario.IdUsuario);

                cmd.Parameters.AddWithValue("@Username", usuario.Username);

                cmd.Parameters.AddWithValue("@PasswordHash",usuario.PasswordHash);

                cmd.Parameters.AddWithValue("@Activo", usuario.Activo);
                cmd.Parameters.AddWithValue("@IdRol",usuario.IdRol);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarUsuario(int idUsuario)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarUsuario", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public E_Usuarios AutenticarUsuario(string username, string passwordHash)
        {
            E_Usuarios usuario = null;

            try
            {
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarUsuarios", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30;

                    cn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {
                            // Obtener valores de forma segura del DataReader
                            int idUsuario = reader.IsDBNull(reader.GetOrdinal("IdUsuario")) ? 0 : Convert.ToInt32(reader["IdUsuario"]);
                            string usernameBD = reader.IsDBNull(reader.GetOrdinal("Username")) ? "" : reader["Username"].ToString();
                            string passwordBD = reader.IsDBNull(reader.GetOrdinal("PasswordHash")) ? "" : reader["PasswordHash"].ToString();
                            int activo = reader.IsDBNull(reader.GetOrdinal("Activo")) ? 0 : Convert.ToInt32(reader["Activo"]);
                            int idRol = reader.IsDBNull(reader.GetOrdinal("IdRol")) ? 0 : Convert.ToInt32(reader["IdRol"]);

                            // Comparar credenciales
                            if (usernameBD.Equals(username, StringComparison.OrdinalIgnoreCase) && 
                                passwordBD == passwordHash && 
                                activo == 1)
                            {
                                usuario = new E_Usuarios
                                {
                                    IdUsuario = idUsuario,
                                    Username = usernameBD,
                                    PasswordHash = passwordBD,
                                    Activo = activo,
                                    IdRol = idRol
                                };
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Error al leer fila: {ex.Message}");
                            continue;
                        }
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en AutenticarUsuario: {ex.Message}");
                throw;
            }

            return usuario;
        }

        public DataTable ObtenerRolUsuario(int idRol)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT IdRol, Nombre FROM Roles WHERE IdRol = @IdRol", cn);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@IdRol", idRol);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }
    }
}
