using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmIngreso : Form
    {
        private int intentosFallidos = 0;
        private const int MAX_INTENTOS = 3;

        N_Usuarios negocioUsuarios = new N_Usuarios();

        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            intentosFallidos = 0;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    MessageBox.Show("Por favor ingrese el usuario", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Por favor ingrese la contraseña", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }

                // Intentar autenticar el usuario
                E_Usuarios usuarioAutenticado = negocioUsuarios.AutenticarUsuario(txtUsuario.Text, txtPassword.Text);

                if (usuarioAutenticado != null && usuarioAutenticado.IdUsuario > 0)
                {
                    // Verificar si el usuario está activo
                    if (usuarioAutenticado.Activo == 0)
                    {
                        MessageBox.Show("Este usuario se encuentra inactivo. Comuníquese con el administrador.", 
                            "Usuario Inactivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Obtener el nombre del rol
                    string nombreRol = AutorizacionRoles.ObtenerNombreRol(usuarioAutenticado.IdRol);

                    // Iniciar sesión del usuario
                    SesionUsuario.IniciarSesion(usuarioAutenticado, nombreRol);

                    // Mostrar mensaje de bienvenida
                    MessageBox.Show($"¡Bienvenido {usuarioAutenticado.Username}!\nRol: {nombreRol}", 
                        "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir el formulario principal según el rol
                    AbrirFormularioPrincipal(usuarioAutenticado.IdRol);

                    // Cerrar el formulario de login
                    this.Close();
                }
                else
                {
                    intentosFallidos++;

                    if (intentosFallidos >= MAX_INTENTOS)
                    {
                        MessageBox.Show($"Número máximo de intentos fallidos ({MAX_INTENTOS}) excedido.\n\nLa aplicación se cerrará.", 
                            "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    else
                    {
                        int intentosRestantes = MAX_INTENTOS - intentosFallidos;
                        MessageBox.Show($"Usuario o contraseña incorrectos.\n\nIntentos restantes: {intentosRestantes}", 
                            "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                        txtUsuario.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante la autenticación:\n\n{ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine($"Exception: {ex}");
            }
        }

        private void AbrirFormularioPrincipal(int idRol)
        {
            try
            {
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario principal: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.Yellow;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.White;
        }

        private void FrmIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == 0)
            {
                btnIngresar_Click(null, null);
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
