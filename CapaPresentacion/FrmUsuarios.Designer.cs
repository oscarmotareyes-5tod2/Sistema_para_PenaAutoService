namespace CapaPresentacion
{
    partial class FrmUsuarios
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
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.labelsub = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.panelUAccionesR = new System.Windows.Forms.Panel();
            this.pbReactivar = new System.Windows.Forms.PictureBox();
            this.btnReactivar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbDesactivaruser = new System.Windows.Forms.PictureBox();
            this.pbNUSer = new System.Windows.Forms.PictureBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnNuevoUser = new System.Windows.Forms.Button();
            this.labelUAccionesR = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.labelUsuarios = new System.Windows.Forms.Label();
            this.panelUsuarios.SuspendLayout();
            this.panelUAccionesR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReactivar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesactivaruser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNUSer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.BackColor = System.Drawing.Color.White;
            this.panelUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsuarios.Controls.Add(this.labelsub);
            this.panelUsuarios.Controls.Add(this.txtBuscar);
            this.panelUsuarios.Controls.Add(this.labelBuscar);
            this.panelUsuarios.Controls.Add(this.panelUAccionesR);
            this.panelUsuarios.Controls.Add(this.dgvUsuarios);
            this.panelUsuarios.Controls.Add(this.labelUsuarios);
            this.panelUsuarios.Location = new System.Drawing.Point(134, 12);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(837, 531);
            this.panelUsuarios.TabIndex = 0;
            this.panelUsuarios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUsuarios_Paint);
            // 
            // labelsub
            // 
            this.labelsub.AutoSize = true;
            this.labelsub.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsub.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelsub.Location = new System.Drawing.Point(36, 55);
            this.labelsub.Name = "labelsub";
            this.labelsub.Size = new System.Drawing.Size(118, 15);
            this.labelsub.TabIndex = 17;
            this.labelsub.Text = "Gestión de Usuarios:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(220, 103);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(129, 20);
            this.txtBuscar.TabIndex = 16;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.Location = new System.Drawing.Point(117, 103);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(97, 15);
            this.labelBuscar.TabIndex = 16;
            this.labelBuscar.Text = "Buscar Usuario:";
            // 
            // panelUAccionesR
            // 
            this.panelUAccionesR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUAccionesR.Controls.Add(this.pbReactivar);
            this.panelUAccionesR.Controls.Add(this.btnReactivar);
            this.panelUAccionesR.Controls.Add(this.pictureBox3);
            this.panelUAccionesR.Controls.Add(this.pbDesactivaruser);
            this.panelUAccionesR.Controls.Add(this.pbNUSer);
            this.panelUAccionesR.Controls.Add(this.btnActualizar);
            this.panelUAccionesR.Controls.Add(this.btnDesactivar);
            this.panelUAccionesR.Controls.Add(this.btnNuevoUser);
            this.panelUAccionesR.Controls.Add(this.labelUAccionesR);
            this.panelUAccionesR.Location = new System.Drawing.Point(555, 140);
            this.panelUAccionesR.Name = "panelUAccionesR";
            this.panelUAccionesR.Size = new System.Drawing.Size(218, 285);
            this.panelUAccionesR.TabIndex = 13;
            this.panelUAccionesR.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUAccionesR_Paint);
            // 
            // pbReactivar
            // 
            this.pbReactivar.Image = global::CapaPresentacion.Properties.Resources.refrescar;
            this.pbReactivar.Location = new System.Drawing.Point(18, 221);
            this.pbReactivar.Name = "pbReactivar";
            this.pbReactivar.Size = new System.Drawing.Size(36, 36);
            this.pbReactivar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReactivar.TabIndex = 24;
            this.pbReactivar.TabStop = false;
            // 
            // btnReactivar
            // 
            this.btnReactivar.Location = new System.Drawing.Point(62, 221);
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Size = new System.Drawing.Size(125, 32);
            this.btnReactivar.TabIndex = 23;
            this.btnReactivar.Text = "Reactivar Usuario";
            this.btnReactivar.UseVisualStyleBackColor = true;
            this.btnReactivar.Click += new System.EventHandler(this.btnReactivar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.refrescar;
            this.pictureBox3.Location = new System.Drawing.Point(18, 116);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pbDesactivaruser
            // 
            this.pbDesactivaruser.Image = global::CapaPresentacion.Properties.Resources.usuario_menos__1_;
            this.pbDesactivaruser.Location = new System.Drawing.Point(18, 168);
            this.pbDesactivaruser.Name = "pbDesactivaruser";
            this.pbDesactivaruser.Size = new System.Drawing.Size(36, 36);
            this.pbDesactivaruser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDesactivaruser.TabIndex = 21;
            this.pbDesactivaruser.TabStop = false;
            // 
            // pbNUSer
            // 
            this.pbNUSer.Image = global::CapaPresentacion.Properties.Resources.agregar_usuario;
            this.pbNUSer.Location = new System.Drawing.Point(16, 61);
            this.pbNUSer.Name = "pbNUSer";
            this.pbNUSer.Size = new System.Drawing.Size(36, 36);
            this.pbNUSer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNUSer.TabIndex = 20;
            this.pbNUSer.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(62, 116);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(125, 32);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar Usuario";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Location = new System.Drawing.Point(62, 168);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(125, 32);
            this.btnDesactivar.TabIndex = 15;
            this.btnDesactivar.Text = "Desactivar Usuario";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnNuevoUser
            // 
            this.btnNuevoUser.Location = new System.Drawing.Point(60, 61);
            this.btnNuevoUser.Name = "btnNuevoUser";
            this.btnNuevoUser.Size = new System.Drawing.Size(125, 32);
            this.btnNuevoUser.TabIndex = 14;
            this.btnNuevoUser.Text = "Nuevo Usuario";
            this.btnNuevoUser.UseVisualStyleBackColor = true;
            this.btnNuevoUser.Click += new System.EventHandler(this.btnNuevoUser_Click);
            // 
            // labelUAccionesR
            // 
            this.labelUAccionesR.AutoSize = true;
            this.labelUAccionesR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUAccionesR.Location = new System.Drawing.Point(25, 14);
            this.labelUAccionesR.Name = "labelUAccionesR";
            this.labelUAccionesR.Size = new System.Drawing.Size(160, 22);
            this.labelUAccionesR.TabIndex = 14;
            this.labelUAccionesR.Text = "Acciones Rapidas:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(30, 140);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(430, 285);
            this.dgvUsuarios.TabIndex = 12;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // labelUsuarios
            // 
            this.labelUsuarios.AutoSize = true;
            this.labelUsuarios.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarios.Location = new System.Drawing.Point(35, 19);
            this.labelUsuarios.Name = "labelUsuarios";
            this.labelUsuarios.Size = new System.Drawing.Size(94, 24);
            this.labelUsuarios.TabIndex = 11;
            this.labelUsuarios.Text = "Usuarios:";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 729);
            this.Controls.Add(this.panelUsuarios);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.Click += new System.EventHandler(this.FrmUsuarios_Click);
            this.panelUsuarios.ResumeLayout(false);
            this.panelUsuarios.PerformLayout();
            this.panelUAccionesR.ResumeLayout(false);
            this.panelUAccionesR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReactivar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesactivaruser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNUSer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Label labelUsuarios;
        private System.Windows.Forms.Panel panelUAccionesR;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnNuevoUser;
        private System.Windows.Forms.Label labelUAccionesR;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbDesactivaruser;
        private System.Windows.Forms.PictureBox pbNUSer;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label labelBuscar;
        public System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label labelsub;
        private System.Windows.Forms.PictureBox pbReactivar;
        private System.Windows.Forms.Button btnReactivar;
    }
}