namespace CapaPresentacion
{
    partial class FrmNuevouser
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
            this.lNombreu = new System.Windows.Forms.Label();
            this.btnGuardarU = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.labelrol = new System.Windows.Forms.Label();
            this.labelContra = new System.Windows.Forms.Label();
            this.panelNuser = new System.Windows.Forms.Panel();
            this.pictureBoxNuser = new System.Windows.Forms.PictureBox();
            this.labelNUSer = new System.Windows.Forms.Label();
            this.paneldatos = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panelNuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNuser)).BeginInit();
            this.paneldatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lNombreu
            // 
            this.lNombreu.AutoSize = true;
            this.lNombreu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreu.Location = new System.Drawing.Point(56, 105);
            this.lNombreu.Name = "lNombreu";
            this.lNombreu.Size = new System.Drawing.Size(97, 22);
            this.lNombreu.TabIndex = 0;
            this.lNombreu.Text = "Username:";
            // 
            // btnGuardarU
            // 
            this.btnGuardarU.Location = new System.Drawing.Point(356, 174);
            this.btnGuardarU.Name = "btnGuardarU";
            this.btnGuardarU.Size = new System.Drawing.Size(111, 34);
            this.btnGuardarU.TabIndex = 1;
            this.btnGuardarU.Text = "Guardar";
            this.btnGuardarU.UseVisualStyleBackColor = true;
            this.btnGuardarU.Click += new System.EventHandler(this.btnGuardarU_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(15, 147);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(176, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(47, 319);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(111, 21);
            this.cmbRol.TabIndex = 3;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(15, 240);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(176, 20);
            this.txtClave.TabIndex = 6;
            // 
            // labelrol
            // 
            this.labelrol.AutoSize = true;
            this.labelrol.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrol.Location = new System.Drawing.Point(88, 284);
            this.labelrol.Name = "labelrol";
            this.labelrol.Size = new System.Drawing.Size(44, 22);
            this.labelrol.TabIndex = 8;
            this.labelrol.Text = "Rol:";
            // 
            // labelContra
            // 
            this.labelContra.AutoSize = true;
            this.labelContra.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContra.Location = new System.Drawing.Point(63, 197);
            this.labelContra.Name = "labelContra";
            this.labelContra.Size = new System.Drawing.Size(95, 22);
            this.labelContra.TabIndex = 7;
            this.labelContra.Text = "Password:";
            this.labelContra.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelNuser
            // 
            this.panelNuser.BackColor = System.Drawing.Color.DarkRed;
            this.panelNuser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNuser.Controls.Add(this.pictureBoxNuser);
            this.panelNuser.Controls.Add(this.labelNUSer);
            this.panelNuser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNuser.Location = new System.Drawing.Point(0, 0);
            this.panelNuser.Name = "panelNuser";
            this.panelNuser.Size = new System.Drawing.Size(503, 104);
            this.panelNuser.TabIndex = 0;
            // 
            // pictureBoxNuser
            // 
            this.pictureBoxNuser.Image = global::CapaPresentacion.Properties.Resources.agregar_usuario__1_;
            this.pictureBoxNuser.Location = new System.Drawing.Point(141, 25);
            this.pictureBoxNuser.Name = "pictureBoxNuser";
            this.pictureBoxNuser.Size = new System.Drawing.Size(41, 34);
            this.pictureBoxNuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNuser.TabIndex = 1;
            this.pictureBoxNuser.TabStop = false;
            // 
            // labelNUSer
            // 
            this.labelNUSer.AutoSize = true;
            this.labelNUSer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNUSer.ForeColor = System.Drawing.Color.White;
            this.labelNUSer.Location = new System.Drawing.Point(188, 35);
            this.labelNUSer.Name = "labelNUSer";
            this.labelNUSer.Size = new System.Drawing.Size(142, 24);
            this.labelNUSer.TabIndex = 0;
            this.labelNUSer.Text = "Nuevo Usuario";
            // 
            // paneldatos
            // 
            this.paneldatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneldatos.Controls.Add(this.labelNombre);
            this.paneldatos.Controls.Add(this.txtNombre);
            this.paneldatos.Controls.Add(this.lNombreu);
            this.paneldatos.Controls.Add(this.cmbRol);
            this.paneldatos.Controls.Add(this.labelrol);
            this.paneldatos.Controls.Add(this.txtClave);
            this.paneldatos.Controls.Add(this.labelContra);
            this.paneldatos.Controls.Add(this.txtUsuario);
            this.paneldatos.Location = new System.Drawing.Point(94, 131);
            this.paneldatos.Name = "paneldatos";
            this.paneldatos.Size = new System.Drawing.Size(216, 370);
            this.paneldatos.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(356, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(61, 15);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(81, 22);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(20, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // FrmNuevouser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 513);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.paneldatos);
            this.Controls.Add(this.panelNuser);
            this.Controls.Add(this.btnGuardarU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevouser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.FrmNuevouser_Load);
            this.panelNuser.ResumeLayout(false);
            this.panelNuser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNuser)).EndInit();
            this.paneldatos.ResumeLayout(false);
            this.paneldatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lNombreu;
        private System.Windows.Forms.Button btnGuardarU;
        private System.Windows.Forms.Label labelContra;
        private System.Windows.Forms.Label labelrol;
        private System.Windows.Forms.Panel panelNuser;
        private System.Windows.Forms.Panel paneldatos;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.ComboBox cmbRol;
        public System.Windows.Forms.TextBox txtClave;
        public System.Windows.Forms.Label labelNUSer;
        public System.Windows.Forms.PictureBox pictureBoxNuser;
        private System.Windows.Forms.Label labelNombre;
        public System.Windows.Forms.TextBox txtNombre;
    }
}