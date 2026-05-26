using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_VehiculosCRUD
    {
        D_Vehiculos datos = new D_Vehiculos();

        public void Insertar(string placa, string marca, string modelo, int anio, int idCliente)
        {
            datos.Insertar(placa, marca, modelo, anio, idCliente);
        }

        public DataTable Listar()
        {
            return datos.Listar();
        }

        public void Actualizar(int idVehiculo, string placa, string marca, string modelo, int anio, int idCliente)
        {
            datos.Actualizar(idVehiculo, placa, marca, modelo, anio, idCliente);
        }

        public void Eliminar(int idVehiculo)
        {
            datos.Eliminar(idVehiculo);
        }
    }
}
