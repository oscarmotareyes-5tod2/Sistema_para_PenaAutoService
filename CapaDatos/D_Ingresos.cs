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
    public class D_Ingresos
    {
        public void RegistrarIngresoCompleto(E_Ingreso ingreso)
        {
            using (SqlConnection cn =Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_RegistrarIngresoCompleto",cn);

                cmd.CommandType =CommandType.StoredProcedure;

                // CLIENTE
                cmd.Parameters.AddWithValue("@Nombre",ingreso.Nombre);

                cmd.Parameters.AddWithValue("@Telefono",ingreso.Telefono);

                cmd.Parameters.AddWithValue("@Correo",ingreso.Correo);

                cmd.Parameters.AddWithValue("@Direccion",ingreso.Direccion);

                // VEHICULO
                cmd.Parameters.AddWithValue("@Placa",ingreso.Placa);

                cmd.Parameters.AddWithValue("@Marca",ingreso.Marca);

                cmd.Parameters.AddWithValue("@Modelo",ingreso.Modelo);

                cmd.Parameters.AddWithValue("@Anio",ingreso.Anio);

                // ORDEN
                cmd.Parameters.AddWithValue("@IdUsuario",ingreso.IdUsuario);

                cmd.Parameters.AddWithValue("@Fallas",ingreso.Fallas);


                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarVehiculosIngresados()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarVehiculosIngresados", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }
    }
}
