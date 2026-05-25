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
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }
        private void CargarConfiguracion()
        {
            N_Configuracion negocio = new N_Configuracion();

            DataTable dt =negocio.ObtenerConfiguracion();

            if (dt.Rows.Count > 0)
            {
                cmbTema.Text =dt.Rows[0]["Tema"].ToString();

                cmbColor.Text =dt.Rows[0]["ColorPrincipal"].ToString();

                txtRutaBackup.Text =dt.Rows[0]["RutaBackup"].ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            E_Configuracion config = new E_Configuracion();

            config.Tema = cmbTema.Text;
            config.ColorPrincipal = cmbColor.Text;
            config.RutaBackup = txtRutaBackup.Text;

            N_Configuracion negocio =new N_Configuracion();

            negocio.GuardarConfiguracion(config);

            MessageBox.Show("Configuración guardada");
            CargarConfiguracion();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            CargarConfiguracion();
            cmbTema.Items.Add("Claro");
            cmbTema.Items.Add("Oscuro");

            cmbColor.Items.Add("Rojo");
            cmbColor.Items.Add("Azul");
            cmbColor.Items.Add("Verde");
            cmbColor.Items.Add("Negro");
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog carpeta =new FolderBrowserDialog();

            if (carpeta.ShowDialog() ==DialogResult.OK)
            {
                txtRutaBackup.Text =carpeta.SelectedPath;
            }
        }

        private void btnCrearBackup_Click(object sender, EventArgs e)
        {
            try
            {
                N_Configuracion negocio =new N_Configuracion();

                negocio.CrearBackup(txtRutaBackup.Text);

                MessageBox.Show("Backup creado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }

        private void btnExaminar2_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir =new OpenFileDialog();

            abrir.Filter ="Backup SQL (*.bak)|*.bak";

            if (abrir.ShowDialog() ==DialogResult.OK)
            {
                txtRutaRestore.Text =
                    abrir.FileName;
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            DialogResult resultado =
      MessageBox.Show(
          "La base de datos será restaurada. ¿Desea continuar?",
          "Restaurar Backup",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    N_Configuracion negocio = new N_Configuracion();

                    negocio.RestaurarBackup(txtRutaRestore.Text);

                    MessageBox.Show("Backup restaurado correctamente");

                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message);
                }
            }
        }
    }
}
