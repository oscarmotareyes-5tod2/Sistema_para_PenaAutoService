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
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // VALIDAR CAMPOS VACIOS
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContra.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }
            int intentosFallidos = 0;

            try
            {
                N_Usuarios negocio = new N_Usuarios();

                DataTable dt = negocio.Login(
                    txtUsuario.Text.Trim(),
                    txtContra.Text.Trim()
                );

                // VALIDAR LOGIN
                if (dt.Rows.Count > 0)
                {
                    // RESET INTENTOS (IMPORTANTE)
                    intentosFallidos = 0;

                    // GUARDAR DATOS DEL USUARIO EN SESION
                    Sesion.UsuarioActual = new E_Usuarios()
                    {
                        IdUsuario = Convert.ToInt32(dt.Rows[0]["IdUsuario"]),
                        Username = dt.Rows[0]["Username"].ToString(),
                        Nombre = dt.Rows[0]["Nombre"].ToString(),
                        IdRol = Convert.ToInt32(dt.Rows[0]["IdRol"]),
                        NombreRol = dt.Rows[0]["NombreRol"].ToString()
                    };

                    MessageBox.Show(
                        "Bienvenido " + Sesion.UsuarioActual.Nombre,
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // ABRIR FORM PRINCIPAL
                    FormPrincipal frm = new FormPrincipal();
                    frm.Show();

                    // OCULTAR LOGIN
                    this.Hide();
                }
                else
                {
                    // 🔥 AUMENTAR INTENTOS FALLIDOS
                    intentosFallidos++;

                    MessageBox.Show(
                        "Usuario, contraseña incorrecta o usuario inactivo",
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    txtContra.Clear();
                    txtContra.Focus();

                    // 🔴 VALIDAR 3 INTENTOS
                    if (intentosFallidos >= 3)
                    {
                        MessageBox.Show(
                            "Has superado los 3 intentos. El sistema se cerrará.",
                            "Bloqueo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                        );

                        Application.Exit(); // CIERRA TODO EL SISTEMA
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado =
            MessageBox.Show(
                "¿Desea salir del sistema?",
                "Sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
