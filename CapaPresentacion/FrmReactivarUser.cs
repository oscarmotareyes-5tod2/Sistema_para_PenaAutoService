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
    public partial class FrmReactivarUser : Form
    {
        private Panel panelRuser;
        public PictureBox pictureBoxRuser;
        private DataGridView dgvRuser;
        private Button btnReactivar;
        private Button btnCancelar;
        private TextBox txtRBuscar;
        private Label labelRBuscar;
        public Label labelRUSer;

        public FrmReactivarUser()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panelRuser = new System.Windows.Forms.Panel();
            this.pictureBoxRuser = new System.Windows.Forms.PictureBox();
            this.labelRUSer = new System.Windows.Forms.Label();
            this.dgvRuser = new System.Windows.Forms.DataGridView();
            this.btnReactivar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtRBuscar = new System.Windows.Forms.TextBox();
            this.labelRBuscar = new System.Windows.Forms.Label();
            this.panelRuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRuser
            // 
            this.panelRuser.BackColor = System.Drawing.Color.DarkRed;
            this.panelRuser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRuser.Controls.Add(this.pictureBoxRuser);
            this.panelRuser.Controls.Add(this.labelRUSer);
            this.panelRuser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRuser.Location = new System.Drawing.Point(0, 0);
            this.panelRuser.Name = "panelRuser";
            this.panelRuser.Size = new System.Drawing.Size(578, 104);
            this.panelRuser.TabIndex = 1;
            // 
            // pictureBoxRuser
            // 
            this.pictureBoxRuser.Image = global::CapaPresentacion.Properties.Resources.refrescar__1_;
            this.pictureBoxRuser.Location = new System.Drawing.Point(141, 25);
            this.pictureBoxRuser.Name = "pictureBoxRuser";
            this.pictureBoxRuser.Size = new System.Drawing.Size(41, 34);
            this.pictureBoxRuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRuser.TabIndex = 1;
            this.pictureBoxRuser.TabStop = false;
            // 
            // labelRUSer
            // 
            this.labelRUSer.AutoSize = true;
            this.labelRUSer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRUSer.ForeColor = System.Drawing.Color.White;
            this.labelRUSer.Location = new System.Drawing.Point(188, 35);
            this.labelRUSer.Name = "labelRUSer";
            this.labelRUSer.Size = new System.Drawing.Size(172, 24);
            this.labelRUSer.TabIndex = 0;
            this.labelRUSer.Text = "Reactivar Usuario";
            // 
            // dgvRuser
            // 
            this.dgvRuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRuser.Location = new System.Drawing.Point(34, 182);
            this.dgvRuser.Name = "dgvRuser";
            this.dgvRuser.Size = new System.Drawing.Size(341, 285);
            this.dgvRuser.TabIndex = 2;
            // 
            // btnReactivar
            // 
            this.btnReactivar.Location = new System.Drawing.Point(420, 265);
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Size = new System.Drawing.Size(118, 34);
            this.btnReactivar.TabIndex = 3;
            this.btnReactivar.Text = "Reactivar";
            this.btnReactivar.UseVisualStyleBackColor = true;
            this.btnReactivar.Click += new System.EventHandler(this.btnReactivar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(420, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 34);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtRBuscar
            // 
            this.txtRBuscar.Location = new System.Drawing.Point(190, 151);
            this.txtRBuscar.Name = "txtRBuscar";
            this.txtRBuscar.Size = new System.Drawing.Size(129, 20);
            this.txtRBuscar.TabIndex = 17;
            this.txtRBuscar.TextChanged += new System.EventHandler(this.txtRBuscar_TextChanged);
            // 
            // labelRBuscar
            // 
            this.labelRBuscar.AutoSize = true;
            this.labelRBuscar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRBuscar.Location = new System.Drawing.Point(87, 151);
            this.labelRBuscar.Name = "labelRBuscar";
            this.labelRBuscar.Size = new System.Drawing.Size(97, 15);
            this.labelRBuscar.TabIndex = 18;
            this.labelRBuscar.Text = "Buscar Usuario:";
            // 
            // FrmReactivarUser
            // 
            this.ClientSize = new System.Drawing.Size(578, 479);
            this.Controls.Add(this.txtRBuscar);
            this.Controls.Add(this.labelRBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReactivar);
            this.Controls.Add(this.dgvRuser);
            this.Controls.Add(this.panelRuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReactivarUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmReactivarUser_Load);
            this.Click += new System.EventHandler(this.FrmReactivarUser_Click);
            this.panelRuser.ResumeLayout(false);
            this.panelRuser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        N_Usuarios negocio = new N_Usuarios();
        private void BuscarUsuariosDes()
        {
            dgvRuser.DataSource = negocio.BuscarUsuariosDesactivados(txtRBuscar.Text);
        }
        FrmUsuarios gr = new FrmUsuarios();
        private void ListarUsuarios()
        {
            gr.dgvUsuarios.DataSource = negocio.ListarUsuarios();
        }

        private void ListarUser2()
        {
            dgvRuser.DataSource = negocio.ListarUsuariosDesactivados();
        }

        private void EstiloDataGridView()
        {
            dgvRuser.BorderStyle = BorderStyle.None;
            dgvRuser.BackgroundColor = Color.White;

            dgvRuser.EnableHeadersVisualStyles = false;
            dgvRuser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // HEADER DARK RED
            dgvRuser.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvRuser.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRuser.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            // FILAS
            dgvRuser.DefaultCellStyle.BackColor = Color.White;
            dgvRuser.DefaultCellStyle.ForeColor = Color.Black;
            dgvRuser.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            // FILAS ALTERNAS
            dgvRuser.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            // SELECCION AZUL
            dgvRuser.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(0, 120, 215);

            dgvRuser.DefaultCellStyle.SelectionForeColor = Color.White;

            // TAMAÑO
            dgvRuser.RowTemplate.Height = 35;

            // AJUSTAR COLUMNAS
            dgvRuser.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // SELECCION COMPLETA
            dgvRuser.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvRuser.MultiSelect = false;

            // QUITAR ENCABEZADO IZQUIERDO
            dgvRuser.RowHeadersVisible = false;

            // COLOR DE LINEAS
            dgvRuser.GridColor = Color.LightGray;
        }

        private void txtRBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuariosDes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            if (dgvRuser.SelectedRows.Count == 0)
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
                    "¿Desea Reactivar este usuario?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            int idUsuario = Convert.ToInt32(
                dgvRuser.SelectedRows[0]
                .Cells["IdUsuario"].Value);

            negocio.ResactivarUsuario(idUsuario);
            ListarUsuarios();
            MessageBox.Show(
                "Usuario Activado");
            ListarUser2();
        }

        private void FrmReactivarUser_Load(object sender, EventArgs e)
        {
            ListarUser2();
             dgvRuser.Columns["IdUsuario"].Visible = false;
            dgvRuser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRuser.ClearSelection();
            dgvRuser.CurrentCell = null;
            EstiloDataGridView();
        }

        private void FrmReactivarUser_Click(object sender, EventArgs e)
        {
            dgvRuser.ClearSelection();
            dgvRuser.CurrentCell = null;
        }
    }
}
