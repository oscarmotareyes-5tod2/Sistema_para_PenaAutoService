using CapaEntidades;
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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        N_Usuarios user = new N_Usuarios();
        N_Roles roles = new N_Roles();
        int idUsuario = 0;

        private void ListarUsuarios()
        {
            dgvUsuarios.DataSource =
               user .ListarUsuarios();
        }

      

        private void BuscarUsuarios()
        {
            N_Usuarios negocio =new N_Usuarios();

            dgvUsuarios.DataSource = negocio.BuscarUsuarios(txtBuscar.Text);
        }

        private void panelUsuarios_Paint(object sender, PaintEventArgs e)
        {
            EstiloDataGridView();
            dgvUsuarios.ClearSelection();
            dgvUsuarios.ClearSelection();
            dgvUsuarios.CurrentCell = null;

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
            dgvUsuarios.Columns["IdUsuario"].Visible = false;
            dgvUsuarios.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.ClearSelection();
            dgvUsuarios.CurrentCell = null;

        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un usuario",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult resultado =
                MessageBox.Show(
                    "¿Desea desactivar este usuario?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            int idUsuario = Convert.ToInt32(
                dgvUsuarios.SelectedRows[0]
                .Cells["IdUsuario"].Value);

            user.DesactivarUsuario(idUsuario);

            MessageBox.Show(
                "Usuario desactivado");

            ListarUsuarios();
        }

       

      

        private void btnNuevoUser_Click(object sender, EventArgs e)
        {

            FrmNuevouser frm =new  FrmNuevouser();

            frm.ShowDialog();
            ListarUsuarios();

        }


       

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           


 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            } 
            

            else
            {
                FrmNuevouser frm = new FrmNuevouser();
                frm.idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);

                frm.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();

                frm.txtNombre.Text = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();

                frm.txtClave.Text = dgvUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();

                frm.cmbRol.SelectedText = dgvUsuarios.CurrentRow.Cells["Rol"].Value.ToString();

                frm.esEditar = true; frm.ShowDialog();
                ListarUsuarios();
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EstiloDataGridView()
        {
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.BackgroundColor = Color.White;

            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // HEADER DARK RED
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            // FILAS
            dgvUsuarios.DefaultCellStyle.BackColor = Color.White;
            dgvUsuarios.DefaultCellStyle.ForeColor = Color.Black;
            dgvUsuarios.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            // FILAS ALTERNAS
            dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            // SELECCION AZUL
            dgvUsuarios.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(0, 120, 215);

            dgvUsuarios.DefaultCellStyle.SelectionForeColor = Color.White;

            // TAMAÑO
            dgvUsuarios.RowTemplate.Height = 35;

            // AJUSTAR COLUMNAS
            dgvUsuarios.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // SELECCION COMPLETA
            dgvUsuarios.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvUsuarios.MultiSelect = false;

            // QUITAR ENCABEZADO IZQUIERDO
            dgvUsuarios.RowHeadersVisible = false;

            // COLOR DE LINEAS
            dgvUsuarios.GridColor = Color.LightGray;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }

        private void FrmUsuarios_Click(object sender, EventArgs e)
        {
            dgvUsuarios.ClearSelection();
            dgvUsuarios.CurrentCell = null;
        }

        private void panelUAccionesR_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            FrmReactivarUser Ruser = new FrmReactivarUser();
            Ruser.ShowDialog();
            ListarUsuarios();
        }
    }
}
