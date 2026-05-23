using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmVehiculos : Form
    {
        public FrmVehiculos()
        {
            InitializeComponent();
        }

        N_OrdenesTrabajo negocio = new N_OrdenesTrabajo();

        N_Vehiculos vehi = new N_Vehiculos();

        private void CargarEstadisticas()
        {
            labelNRecibidos.Text =
                negocio.TotalPorEstado("Recibido").ToString();

            labelNRevision.Text =
                negocio.TotalPorEstado("En Revision").ToString();

            labelNReparacion.Text =
                negocio.TotalPorEstado("En Reparacion").ToString();

            labelNListos.Text =
                negocio.TotalPorEstado("Listo").ToString();

            labelNTodos.Text=
                negocio.TotalNoEntregados().ToString();
        }

        private void CargarVehiculos()
        {
            dgvVehiculos.DataSource =
                vehi.ListarVehiculosDashboard();
        }
        private void Form2Principal_Load(object sender, EventArgs e)
        {
            CargarEstadisticas();
            CargarVehiculos();
            dgvVehiculos.Columns["IdOrden"].Visible = false;
            EstiloDataGridView();
            dgvVehiculos.ClearSelection();
            dgvVehiculos.CurrentCell = null;
            dgvVehiculos.AllowUserToAddRows = false;
        }

        private void EstiloDataGridView()
        {
            dgvVehiculos.BorderStyle = BorderStyle.None;
            dgvVehiculos.BackgroundColor = Color.White;

            dgvVehiculos.EnableHeadersVisualStyles = false;
            dgvVehiculos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // HEADER DARK RED
            dgvVehiculos.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvVehiculos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVehiculos.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            // FILAS
            dgvVehiculos.DefaultCellStyle.BackColor = Color.White;
            dgvVehiculos.DefaultCellStyle.ForeColor = Color.Black;
            dgvVehiculos.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            // FILAS ALTERNAS
            dgvVehiculos.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            // SELECCION AZUL
            dgvVehiculos.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(0, 120, 215);

            dgvVehiculos.DefaultCellStyle.SelectionForeColor = Color.White;

            // TAMAÑO
            dgvVehiculos.RowTemplate.Height = 35;

            // AJUSTAR COLUMNAS
            dgvVehiculos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // SELECCION COMPLETA
            dgvVehiculos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvVehiculos.MultiSelect = false;

            // QUITAR ENCABEZADO IZQUIERDO
            dgvVehiculos.RowHeadersVisible = false;

            // COLOR DE LINEAS
            dgvVehiculos.GridColor = Color.LightGray;
        }

        private void panelRecibidos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxTodos_Click(object sender, EventArgs e)
        {
            dgvVehiculos.DataSource =
                vehi.ListarVehiculosDashboard();
        }

        private void pictureBoxRecibidos_Click(object sender, EventArgs e)
        {
            dgvVehiculos.DataSource =
                vehi.ListarVehiculosPorEstado("Recibido");
        }

        private void pictureBoxRevision_Click(object sender, EventArgs e)
        {
            dgvVehiculos.DataSource =
                vehi.ListarVehiculosPorEstado("En Revision");
        }

        private void pictureBoxReparacion_Click(object sender, EventArgs e)
        {
            dgvVehiculos.DataSource =
                vehi.ListarVehiculosPorEstado("En Reparacion");
        }

        private void pictureBoxListos_Click(object sender, EventArgs e)
        {
            dgvVehiculos.DataSource =
                vehi.ListarVehiculosPorEstado("Listo");
        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2Principal_Click(object sender, EventArgs e)
        {
            dgvVehiculos.ClearSelection();
            dgvVehiculos.CurrentCell = null;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvVehiculos.DataSource =
            vehi.BuscarVehiculos(txtBuscar.Text);
        }

        private void dgvVehiculos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvVehiculos.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.Value == null)
                    return;

                string estado = e.Value.ToString();

                switch (estado)
                {
                    case "Recibido":
                        e.CellStyle.BackColor = Color.DodgerBlue;
                        e.CellStyle.ForeColor = Color.White;
                        break;

                    case "En Revision":
                        e.CellStyle.BackColor = Color.Orange;
                        e.CellStyle.ForeColor = Color.Black;
                        break;

                    case "En Reparacion":
                        e.CellStyle.BackColor = Color.Gold;
                        e.CellStyle.ForeColor = Color.Black;
                        break;

                    case "Listo":
                        e.CellStyle.BackColor = Color.LimeGreen;
                        e.CellStyle.ForeColor = Color.White;
                        break;

                    case "Entregado":
                        e.CellStyle.BackColor = Color.Gray;
                        e.CellStyle.ForeColor = Color.White;
                        break;
                }
            }
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un vehículo");
                return;
            }

            string estado = dgvVehiculos.SelectedRows[0]
                .Cells["Estado"].Value.ToString();

            if (estado != "Listo")
            {
                MessageBox.Show("El vehículo no está listo.");
                return;
            }

            int idOrden = Convert.ToInt32(
                dgvVehiculos.SelectedRows[0]
                .Cells["IdOrden"].Value);

            N_Vehiculos.EntregarVehiculo(idOrden);

            MessageBox.Show("Vehículo entregado.");

            // RECARGAR GRID
            CargarVehiculos();
        }
    }
}
