using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmNuevoIngreso : Form
    {
        public FrmNuevoIngreso()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtPlaca.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAnio.Clear();
            txtFalla.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (HayDatosEnFormulario())
            {
                DialogResult resultado = MessageBox.Show(
                    "Hay datos ingresados. ¿Seguro que deseas cancelar?",
                    "Confirmar cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.No)
                    return;
            }

            else
            {
                this.Close();
            }
        }
        private bool HayDatosEnFormulario()
        {
            return !string.IsNullOrWhiteSpace(txtNombre.Text) ||
                   !string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                   !string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                   !string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                   !string.IsNullOrWhiteSpace(txtPlaca.Text) ||
                   !string.IsNullOrWhiteSpace(txtMarca.Text) ||
                   !string.IsNullOrWhiteSpace(txtModelo.Text) ||
                   !string.IsNullOrWhiteSpace(txtAnio.Text) ||
                   !string.IsNullOrWhiteSpace(txtFalla.Text);
        }

        private void FrmNuevoIngreso_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x00020000;
                return cp;
            }
        }

        private bool ValidarFormulario()
        {
            // NOMBRE
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese el nombre del cliente");

                txtNombre.Focus();

                return false;
            }

            // TELÉFONO
            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese el teléfono");

                txtTelefono.Focus();

                return false;
            }

            // PLACA
            if (txtPlaca.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese la placa");

                txtPlaca.Focus();

                return false;
            }

            // MARCA
            if (txtMarca.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese la marca");

                txtMarca.Focus();

                return false;
            }

            // MODELO
            if (txtModelo.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese el modelo");

                txtModelo.Focus();

                return false;
            }

            // AÑO
            if (txtAnio.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese el año del vehículo");

                txtAnio.Focus();

                return false;
            }

            if (!int.TryParse(txtAnio.Text, out int anio))
            {
                MessageBox.Show(
                    "Ingrese un año válido");

                txtAnio.Focus();

                return false;
            }

            if (anio < 1900 || anio > DateTime.Now.Year + 1)
            {
                MessageBox.Show(
                    "Ingrese un año válido");

                txtAnio.Focus();

                return false;
            }





            // VALIDAR CORREO (OPCIONAL)
            if (txtCorreo.Text.Trim() != "")
            {
                if (!txtCorreo.Text.Contains("@") ||
                    !txtCorreo.Text.Contains("."))
                {
                    MessageBox.Show(
                        "Ingrese un correo válido");

                    txtCorreo.Focus();

                    return false;
                }
            }

            return true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                E_Ingreso ingreso =new E_Ingreso();

                // CLIENTE
                ingreso.Nombre =txtNombre.Text;

                ingreso.Telefono =txtTelefono.Text;

                ingreso.Correo =string.IsNullOrWhiteSpace(txtCorreo.Text)? null: txtCorreo.Text.Trim();

                ingreso.Direccion =string.IsNullOrWhiteSpace(txtDireccion.Text)? null: txtDireccion.Text.Trim();

                // VEHICULO
                ingreso.Placa =txtPlaca.Text;

                ingreso.Marca =txtMarca.Text;

                ingreso.Modelo =txtModelo.Text;

                ingreso.Anio =Convert.ToInt32(txtAnio.Text);

                // ORDEN
                ingreso.IdUsuario = Sesion.UsuarioActual.IdUsuario;

                ingreso.Fallas =txtFalla.Text;

                N_Ingresos negocio =new N_Ingresos();

                negocio.RegistrarIngresoCompleto(ingreso);
                ValidarFormulario();
                MessageBox.Show("Ingreso registrado correctamente");
                LimpiarCampos();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
               !char.IsWhiteSpace(e.KeyChar) &&
               !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            txtPlaca.Text = txtPlaca.Text.ToUpper();

            txtPlaca.SelectionStart =txtPlaca.Text.Length;
        }
    }
}
