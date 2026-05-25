namespace CapaPresentacion
{
    partial class FrmConfiguracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelConfigu = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.labelTema = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.labelBackup = new System.Windows.Forms.Label();
            this.txtRutaBackup = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCrearBackup = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbCBackup = new System.Windows.Forms.PictureBox();
            this.pbApariencia = new System.Windows.Forms.PictureBox();
            this.pbRestaurarBackup = new System.Windows.Forms.PictureBox();
            this.txtRutaRestore = new System.Windows.Forms.TextBox();
            this.btnExaminar2 = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.labelRestaurar = new System.Windows.Forms.Label();
            this.panelConfigu.SuspendLayout();
            this.panelEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApariencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurarBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConfigu
            // 
            this.panelConfigu.BackColor = System.Drawing.Color.White;
            this.panelConfigu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConfigu.Controls.Add(this.labelRestaurar);
            this.panelConfigu.Controls.Add(this.btnRestaurar);
            this.panelConfigu.Controls.Add(this.btnExaminar2);
            this.panelConfigu.Controls.Add(this.txtRutaRestore);
            this.panelConfigu.Controls.Add(this.pbRestaurarBackup);
            this.panelConfigu.Controls.Add(this.pbApariencia);
            this.panelConfigu.Controls.Add(this.pbCBackup);
            this.panelConfigu.Controls.Add(this.btnCrearBackup);
            this.panelConfigu.Controls.Add(this.btnExaminar);
            this.panelConfigu.Controls.Add(this.btnGuardar);
            this.panelConfigu.Controls.Add(this.txtRutaBackup);
            this.panelConfigu.Controls.Add(this.labelBackup);
            this.panelConfigu.Controls.Add(this.cmbColor);
            this.panelConfigu.Controls.Add(this.cmbTema);
            this.panelConfigu.Controls.Add(this.labelColor);
            this.panelConfigu.Controls.Add(this.labelTema);
            this.panelConfigu.Controls.Add(this.panelEncabezado);
            this.panelConfigu.Location = new System.Drawing.Point(103, 38);
            this.panelConfigu.Name = "panelConfigu";
            this.panelConfigu.Size = new System.Drawing.Size(906, 550);
            this.panelConfigu.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(345, 34);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(165, 24);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "⚙️ Configuración";
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelEncabezado.Controls.Add(this.labelTitulo);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(904, 76);
            this.panelEncabezado.TabIndex = 1;
            // 
            // labelTema
            // 
            this.labelTema.AutoSize = true;
            this.labelTema.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTema.Location = new System.Drawing.Point(368, 313);
            this.labelTema.Name = "labelTema";
            this.labelTema.Size = new System.Drawing.Size(132, 19);
            this.labelTema.TabIndex = 2;
            this.labelTema.Text = "Tema del Sistema:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(368, 366);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(113, 19);
            this.labelColor.TabIndex = 3;
            this.labelColor.Text = "Color Principal:";
            // 
            // cmbTema
            // 
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Location = new System.Drawing.Point(353, 335);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(149, 21);
            this.cmbTema.TabIndex = 4;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(353, 388);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(149, 21);
            this.cmbColor.TabIndex = 5;
            // 
            // labelBackup
            // 
            this.labelBackup.AutoSize = true;
            this.labelBackup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackup.Location = new System.Drawing.Point(75, 303);
            this.labelBackup.Name = "labelBackup";
            this.labelBackup.Size = new System.Drawing.Size(167, 19);
            this.labelBackup.TabIndex = 6;
            this.labelBackup.Text = "Ruta Para los Backups:";
            // 
            // txtRutaBackup
            // 
            this.txtRutaBackup.Location = new System.Drawing.Point(64, 343);
            this.txtRutaBackup.Name = "txtRutaBackup";
            this.txtRutaBackup.Size = new System.Drawing.Size(178, 20);
            this.txtRutaBackup.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkRed;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(372, 493);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 36);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(64, 382);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 24);
            this.btnExaminar.TabIndex = 9;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // btnCrearBackup
            // 
            this.btnCrearBackup.Location = new System.Drawing.Point(153, 382);
            this.btnCrearBackup.Name = "btnCrearBackup";
            this.btnCrearBackup.Size = new System.Drawing.Size(89, 24);
            this.btnCrearBackup.TabIndex = 10;
            this.btnCrearBackup.Text = "Crear Backup";
            this.btnCrearBackup.UseVisualStyleBackColor = true;
            this.btnCrearBackup.Click += new System.EventHandler(this.btnCrearBackup_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbCBackup
            // 
            this.pbCBackup.Image = global::CapaPresentacion.Properties.Resources.gestion_de_bases_de_datos;
            this.pbCBackup.Location = new System.Drawing.Point(79, 121);
            this.pbCBackup.Name = "pbCBackup";
            this.pbCBackup.Size = new System.Drawing.Size(163, 150);
            this.pbCBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCBackup.TabIndex = 11;
            this.pbCBackup.TabStop = false;
            // 
            // pbApariencia
            // 
            this.pbApariencia.Image = global::CapaPresentacion.Properties.Resources.cepillar;
            this.pbApariencia.Location = new System.Drawing.Point(353, 121);
            this.pbApariencia.Name = "pbApariencia";
            this.pbApariencia.Size = new System.Drawing.Size(149, 150);
            this.pbApariencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApariencia.TabIndex = 12;
            this.pbApariencia.TabStop = false;
            // 
            // pbRestaurarBackup
            // 
            this.pbRestaurarBackup.Image = global::CapaPresentacion.Properties.Resources.proceso_de_datos;
            this.pbRestaurarBackup.Location = new System.Drawing.Point(626, 121);
            this.pbRestaurarBackup.Name = "pbRestaurarBackup";
            this.pbRestaurarBackup.Size = new System.Drawing.Size(151, 150);
            this.pbRestaurarBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRestaurarBackup.TabIndex = 13;
            this.pbRestaurarBackup.TabStop = false;
            // 
            // txtRutaRestore
            // 
            this.txtRutaRestore.Location = new System.Drawing.Point(612, 343);
            this.txtRutaRestore.Name = "txtRutaRestore";
            this.txtRutaRestore.Size = new System.Drawing.Size(178, 20);
            this.txtRutaRestore.TabIndex = 14;
            // 
            // btnExaminar2
            // 
            this.btnExaminar2.Location = new System.Drawing.Point(608, 382);
            this.btnExaminar2.Name = "btnExaminar2";
            this.btnExaminar2.Size = new System.Drawing.Size(75, 24);
            this.btnExaminar2.TabIndex = 15;
            this.btnExaminar2.Text = "Examinar";
            this.btnExaminar2.UseVisualStyleBackColor = true;
            this.btnExaminar2.Click += new System.EventHandler(this.btnExaminar2_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(697, 382);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(103, 24);
            this.btnRestaurar.TabIndex = 16;
            this.btnRestaurar.Text = "Restaurar Backup";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // labelRestaurar
            // 
            this.labelRestaurar.AutoSize = true;
            this.labelRestaurar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestaurar.Location = new System.Drawing.Point(595, 313);
            this.labelRestaurar.Name = "labelRestaurar";
            this.labelRestaurar.Size = new System.Drawing.Size(216, 19);
            this.labelRestaurar.TabIndex = 17;
            this.labelRestaurar.Text = "Ruta Para Restaurar Backups:";
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 729);
            this.Controls.Add(this.panelConfigu);
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfiguracion";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.panelConfigu.ResumeLayout(false);
            this.panelConfigu.PerformLayout();
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApariencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurarBackup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConfigu;
        private System.Windows.Forms.Label labelTitulo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label labelBackup;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelTema;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtRutaBackup;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnCrearBackup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbCBackup;
        private System.Windows.Forms.PictureBox pbRestaurarBackup;
        private System.Windows.Forms.PictureBox pbApariencia;
        private System.Windows.Forms.Button btnExaminar2;
        private System.Windows.Forms.TextBox txtRutaRestore;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Label labelRestaurar;
    }
}