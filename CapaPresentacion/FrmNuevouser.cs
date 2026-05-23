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
    public partial class FrmNuevouser : Form
    {
        public FrmNuevouser()
        {
            InitializeComponent();
        }
        N_Usuarios negocio =new N_Usuarios();

        private void FrmNuevouser_Load(object sender, EventArgs e)
        {
            CargarRoles();
            
            

            if (esEditar)
            {
                btnGuardarU.Text =
                    "Actualizar";
            }
            else
            {
                btnGuardarU.Text =
                    "Guardar";
                cmbRol.SelectedIndex = -1;
            }
        }

        N_Roles negocioRoles =new N_Roles();

        private void CargarRoles()
        {
            cmbRol.DataSource = negocioRoles.ListarRoles();

            cmbRol.DisplayMember = "NombreRol";
            cmbRol.ValueMember = "IdRol";

            cmbRol.SelectedIndex = -1;
        }

        FrmUsuarios gr = new FrmUsuarios();
        private void ListarUsuarios()
        {
            gr.dgvUsuarios.DataSource = negocio.ListarUsuarios();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        public int idUsuario = 0;

        public bool esEditar = false;

        private void btnGuardarU_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (txtUsuario.Text.Trim() == "" &&
                    txtClave.Text.Trim() == "" &&
                    cmbRol.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Complete los campos",
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtUsuario.Focus();

                    return;
                }

                // VALIDAR USUARIO
                if (txtUsuario.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Ingrese un usuario");

                    txtUsuario.Focus();

                    return;
                }

                // VALIDAR CONTRASEÑA
                if (txtClave.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Ingrese una contraseña");

                    txtClave.Focus();

                    return;
                }

                // VALIDAR ROL
                if (cmbRol.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un rol");

                    cmbRol.Focus();

                    return;
                }

                // LONGITUD USUARIO
                if (txtUsuario.Text.Length < 4)
                {
                    MessageBox.Show(
                        "El usuario debe tener mínimo 4 caracteres",
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtUsuario.Focus();

                    return;
                }

                // LONGITUD CONTRASEÑA
                if (txtClave.Text.Length < 4)
                {
                    MessageBox.Show(
                        "La contraseña debe tener mínimo 4 caracteres",
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtClave.Focus();

                    return;
                }

                // CREAR OBJETO
                E_Usuarios usuario =
                    new E_Usuarios();

                usuario.Username =
                    txtUsuario.Text.Trim();

                usuario.PasswordHash =
                    txtClave.Text.Trim();

                usuario.IdRol =
                    Convert.ToInt32(
                        cmbRol.SelectedValue);

                N_Usuarios negocio =
                    new N_Usuarios();

                // VALIDAR ROL
                if (cmbRol.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un rol",
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbRol.Focus();

                    return;
                }





                // INSERTAR
                if (idUsuario == 0)
                {
                    // VALIDAR DUPLICADO
                    if (negocio.ExisteUsuario(
                        txtUsuario.Text) > 0)
                    {
                        MessageBox.Show(
                            "El usuario ya existe");

                        return;
                    }

                    negocio.InsertarUsuario(usuario);
                    ListarUsuarios();
                    

                    MessageBox.Show(
                        "Usuario registrado");
                }
                else
                {
                    // ACTUALIZAR
                    usuario.IdUsuario = idUsuario;

                    negocio.ActualizarUsuario(usuario);
                    ListarUsuarios();

                    // CONFIRMAR ACTUALIZACIÓN
                    DialogResult resultado =
                        MessageBox.Show(
                            "¿Desea actualizar este usuario?",
                            "Confirmar",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                    if (resultado == DialogResult.No)
                    {
                        return;
                    }

                    MessageBox.Show(
                        "Usuario actualizado");
                }

                // RECARGAR GRID
               

                // LIMPIAR
                txtUsuario.Clear();

                txtClave.Clear();

                cmbRol.SelectedIndex = -1;

                // RESETEAR
                idUsuario = 0;

                btnGuardarU.Text = "Guardar";

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
