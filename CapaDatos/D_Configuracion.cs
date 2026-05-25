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
    public class D_Configuracion
    {
        public void GuardarConfiguracion(E_Configuracion config)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_GuardarConfiguracion", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Tema", config.Tema);

                cmd.Parameters.AddWithValue("@ColorPrincipal", config.ColorPrincipal);

                cmd.Parameters.AddWithValue("@RutaBackup", config.RutaBackup);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void CrearBackup(string ruta)
        {
            using (SqlConnection cn =Conexion.ObtenerConexion())
            {
                string nombreBackup ="TallerDB_" +DateTime.Now.ToString("yyyyMMdd_HHmmss") +".bak";

                string rutaCompleta =ruta + "\\" + nombreBackup;

                string query =$@"BACKUP DATABASE PenaAutoServiceDB TO DISK = '{rutaCompleta}'WITH FORMAT,
                MEDIANAME = 'SQLServerBackups',
                NAME = 'BackupCompleto'";

                SqlCommand cmd =new SqlCommand(query, cn);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public void RestaurarBackup(string rutaBackup)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = $@"USE master;ALTER DATABASE PenaAutoServiceDB
                SET SINGLE_USER
                WITH ROLLBACK IMMEDIATE;

                RESTORE DATABASE PenaAutoServiceDB
                FROM DISK = '{rutaBackup}'
                WITH REPLACE;

                ALTER DATABASE PenaAutoServiceDB
                SET MULTI_USER;
                ";

                SqlCommand cmd =new SqlCommand(query, cn);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerConfiguracion()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerConfiguracion", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }
    }
}
