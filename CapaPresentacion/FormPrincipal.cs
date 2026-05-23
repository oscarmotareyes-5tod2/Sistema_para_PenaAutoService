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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(Form formulario)
        {
            PanelContenedor.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            PanelContenedor.Controls.Add(formulario);
            PanelContenedor.Tag = formulario;

            formulario.Show();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            LTitulo.Text = "Dashboard Principal";
            AbrirFormulario(new FrmBienbenida());  
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            LTitulo.Text = "Usuarios del Sistema";
            AbrirFormulario(new FrmUsuarios()); 
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmVehiculos());
            LTitulo.Text = "Gestión de Vehículos en el Taller";
        }
    }
}
