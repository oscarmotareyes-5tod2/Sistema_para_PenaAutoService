namespace CapaPresentacion
{
    partial class FrmLogin
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelEnabezado = new System.Windows.Forms.Panel();
            this.labelInicioSeccion = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.LabelContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelEnabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::CapaPresentacion.Properties.Resources.logotaller;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(1350, 729);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.btnIngresar);
            this.panelLogin.Controls.Add(this.txtContra);
            this.panelLogin.Controls.Add(this.txtUsuario);
            this.panelLogin.Controls.Add(this.LabelContraseña);
            this.panelLogin.Controls.Add(this.labelUserName);
            this.panelLogin.Controls.Add(this.panelEnabezado);
            this.panelLogin.Location = new System.Drawing.Point(467, 145);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(464, 447);
            this.panelLogin.TabIndex = 2;
            // 
            // panelEnabezado
            // 
            this.panelEnabezado.BackColor = System.Drawing.Color.DarkRed;
            this.panelEnabezado.Controls.Add(this.labelInicioSeccion);
            this.panelEnabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEnabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEnabezado.Name = "panelEnabezado";
            this.panelEnabezado.Size = new System.Drawing.Size(464, 76);
            this.panelEnabezado.TabIndex = 0;
            // 
            // labelInicioSeccion
            // 
            this.labelInicioSeccion.AutoSize = true;
            this.labelInicioSeccion.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInicioSeccion.ForeColor = System.Drawing.Color.White;
            this.labelInicioSeccion.Location = new System.Drawing.Point(148, 30);
            this.labelInicioSeccion.Name = "labelInicioSeccion";
            this.labelInicioSeccion.Size = new System.Drawing.Size(166, 24);
            this.labelInicioSeccion.TabIndex = 0;
            this.labelInicioSeccion.Text = "Inicio de Seccion:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(148, 129);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(174, 22);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Nombre de Usuario:";
            // 
            // LabelContraseña
            // 
            this.LabelContraseña.AutoSize = true;
            this.LabelContraseña.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContraseña.Location = new System.Drawing.Point(186, 231);
            this.LabelContraseña.Name = "LabelContraseña";
            this.LabelContraseña.Size = new System.Drawing.Size(110, 22);
            this.LabelContraseña.TabIndex = 2;
            this.LabelContraseña.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(130, 181);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(208, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(130, 279);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(208, 20);
            this.txtContra.TabIndex = 4;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.DarkRed;
            this.btnIngresar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(152, 350);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(162, 35);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkRed;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1072, 654);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(162, 35);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.pbLogo);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelEnabezado.ResumeLayout(false);
            this.panelEnabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label LabelContraseña;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Panel panelEnabezado;
        private System.Windows.Forms.Label labelInicioSeccion;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnSalir;
    }
}