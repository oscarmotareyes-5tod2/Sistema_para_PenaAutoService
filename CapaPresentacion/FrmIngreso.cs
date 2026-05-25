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
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void EstiloDataGridView()
        {
            dgvIngresos.BorderStyle = BorderStyle.None;
            dgvIngresos.BackgroundColor = Color.White;

            dgvIngresos.EnableHeadersVisualStyles = false;
            dgvIngresos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // HEADER DARK RED
            dgvIngresos.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvIngresos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvIngresos.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            // FILAS
            dgvIngresos.DefaultCellStyle.BackColor = Color.White;
            dgvIngresos.DefaultCellStyle.ForeColor = Color.Black;
            dgvIngresos.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            // FILAS ALTERNAS
            dgvIngresos.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            // SELECCION AZUL
            dgvIngresos.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(0, 120, 215);

            dgvIngresos.DefaultCellStyle.SelectionForeColor = Color.White;

            // TAMAÑO
            dgvIngresos.RowTemplate.Height = 35;

            // AJUSTAR COLUMNAS
            dgvIngresos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // SELECCION COMPLETA
            dgvIngresos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvIngresos.MultiSelect = false;

            // QUITAR ENCABEZADO IZQUIERDO
            dgvIngresos.RowHeadersVisible = false;

            // COLOR DE LINEAS
            dgvIngresos.GridColor = Color.LightGray;
        }

        N_Ingresos ingresos = new N_Ingresos();
        private void MostrarVehiculos()
        {
            dgvIngresos.DataSource =ingresos.ListarVehiculosIngresados();

            // Evitar duplicar botón
            if (!dgvIngresos.Columns.Contains("btnGestionar"))
            {
                DataGridViewButtonColumn btn =
                    new DataGridViewButtonColumn();

                btn.Name = "btnGestionar";
                btn.HeaderText = "Acción";
                btn.Text = "Atender";
                btn.UseColumnTextForButtonValue = true;

                dgvIngresos.Columns.Add(btn);
            }
        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            MostrarVehiculos();
            dgvIngresos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EstiloDataGridView();
            dgvIngresos.Columns["IdOrden"].Visible = false;

            dgvIngresos.BorderStyle = BorderStyle.None;

            dgvIngresos.EnableHeadersVisualStyles = false;

            

            dgvIngresos.RowTemplate.Height = 40;

           
        }

        private void dgvIngresos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
            dgvIngresos.Columns[e.ColumnIndex].Name
             == "btnGestionar")
            {
                int idOrden = Convert.ToInt32(
                    dgvIngresos.Rows[e.RowIndex]
                    .Cells["IdOrden"].Value);

              

                // Aquí luego abrirás otro formulario
            }
        }

        private void FrmIngreso_Click(object sender, EventArgs e)
        {
            dgvIngresos.ClearSelection();
            dgvIngresos.CurrentCell = null;
        }
    }
}
