namespace CapaPresentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.pbusuarios = new System.Windows.Forms.PictureBox();
            this.pbhistorial = new System.Windows.Forms.PictureBox();
            this.pbIngresos = new System.Windows.Forms.PictureBox();
            this.pbvehiculos = new System.Windows.Forms.PictureBox();
            this.pbcliente = new System.Windows.Forms.PictureBox();
            this.panelCerrarseccion = new System.Windows.Forms.Panel();
            this.btnCerrarSeccion = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.LTitulo = new System.Windows.Forms.Label();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.pbConfiguracion = new System.Windows.Forms.PictureBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.pictureBoxuser = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.pbPrincipal = new System.Windows.Forms.PictureBox();
            this.PanelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbusuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcliente)).BeginInit();
            this.panelCerrarseccion.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfiguracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxuser)).BeginInit();
            this.PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.DarkRed;
            this.PanelLateral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelLateral.Controls.Add(this.pbusuarios);
            this.PanelLateral.Controls.Add(this.pbhistorial);
            this.PanelLateral.Controls.Add(this.pbIngresos);
            this.PanelLateral.Controls.Add(this.pbvehiculos);
            this.PanelLateral.Controls.Add(this.pbcliente);
            this.PanelLateral.Controls.Add(this.panelCerrarseccion);
            this.PanelLateral.Controls.Add(this.panelLogo);
            this.PanelLateral.Controls.Add(this.btnVehiculos);
            this.PanelLateral.Controls.Add(this.btnHistorial);
            this.PanelLateral.Controls.Add(this.btnIngresos);
            this.PanelLateral.Controls.Add(this.btnUsuarios);
            this.PanelLateral.Controls.Add(this.btnClientes);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(226, 729);
            this.PanelLateral.TabIndex = 0;
            this.PanelLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLateral_Paint);
            // 
            // pbusuarios
            // 
            this.pbusuarios.Image = global::CapaPresentacion.Properties.Resources.agregar_usuario__1_;
            this.pbusuarios.Location = new System.Drawing.Point(33, 368);
            this.pbusuarios.Name = "pbusuarios";
            this.pbusuarios.Size = new System.Drawing.Size(36, 36);
            this.pbusuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbusuarios.TabIndex = 25;
            this.pbusuarios.TabStop = false;
            // 
            // pbhistorial
            // 
            this.pbhistorial.Image = global::CapaPresentacion.Properties.Resources.tiempo_adelante;
            this.pbhistorial.Location = new System.Drawing.Point(33, 440);
            this.pbhistorial.Name = "pbhistorial";
            this.pbhistorial.Size = new System.Drawing.Size(36, 36);
            this.pbhistorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbhistorial.TabIndex = 24;
            this.pbhistorial.TabStop = false;
            // 
            // pbIngresos
            // 
            this.pbIngresos.Image = global::CapaPresentacion.Properties.Resources.bandeja_de_entrada__1_;
            this.pbIngresos.Location = new System.Drawing.Point(33, 296);
            this.pbIngresos.Name = "pbIngresos";
            this.pbIngresos.Size = new System.Drawing.Size(36, 36);
            this.pbIngresos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIngresos.TabIndex = 23;
            this.pbIngresos.TabStop = false;
            // 
            // pbvehiculos
            // 
            this.pbvehiculos.Image = global::CapaPresentacion.Properties.Resources.lado_del_coche;
            this.pbvehiculos.Location = new System.Drawing.Point(33, 227);
            this.pbvehiculos.Name = "pbvehiculos";
            this.pbvehiculos.Size = new System.Drawing.Size(36, 36);
            this.pbvehiculos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbvehiculos.TabIndex = 21;
            this.pbvehiculos.TabStop = false;
            // 
            // pbcliente
            // 
            this.pbcliente.Image = global::CapaPresentacion.Properties.Resources.atencion_al_cliente__3_;
            this.pbcliente.Location = new System.Drawing.Point(33, 156);
            this.pbcliente.Name = "pbcliente";
            this.pbcliente.Size = new System.Drawing.Size(36, 36);
            this.pbcliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcliente.TabIndex = 20;
            this.pbcliente.TabStop = false;
            // 
            // panelCerrarseccion
            // 
            this.panelCerrarseccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCerrarseccion.Controls.Add(this.btnCerrarSeccion);
            this.panelCerrarseccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCerrarseccion.Location = new System.Drawing.Point(0, 625);
            this.panelCerrarseccion.Name = "panelCerrarseccion";
            this.panelCerrarseccion.Size = new System.Drawing.Size(222, 100);
            this.panelCerrarseccion.TabIndex = 13;
            // 
            // btnCerrarSeccion
            // 
            this.btnCerrarSeccion.BackColor = System.Drawing.Color.Brown;
            this.btnCerrarSeccion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSeccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSeccion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSeccion.Location = new System.Drawing.Point(14, 29);
            this.btnCerrarSeccion.Name = "btnCerrarSeccion";
            this.btnCerrarSeccion.Size = new System.Drawing.Size(176, 44);
            this.btnCerrarSeccion.TabIndex = 8;
            this.btnCerrarSeccion.Text = "🔙 Cerrar Seccion";
            this.btnCerrarSeccion.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogo.Controls.Add(this.pictureIcon);
            this.panelLogo.Controls.Add(this.btnPrincipal);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(222, 98);
            this.panelLogo.TabIndex = 12;
            // 
            // pictureIcon
            // 
            this.pictureIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureIcon.Image = global::CapaPresentacion.Properties.Resources.herramientas__2_;
            this.pictureIcon.Location = new System.Drawing.Point(15, 37);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(42, 37);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIcon.TabIndex = 2;
            this.pictureIcon.TabStop = false;
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnPrincipal.Location = new System.Drawing.Point(63, 30);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(139, 44);
            this.btnPrincipal.TabIndex = 9;
            this.btnPrincipal.Text = "AutoControl";
            this.btnPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.FlatAppearance.BorderSize = 0;
            this.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculos.ForeColor = System.Drawing.Color.White;
            this.btnVehiculos.Location = new System.Drawing.Point(75, 227);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(129, 44);
            this.btnVehiculos.TabIndex = 10;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculos.UseVisualStyleBackColor = true;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Location = new System.Drawing.Point(75, 440);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(139, 44);
            this.btnHistorial.TabIndex = 6;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnIngresos
            // 
            this.btnIngresos.FlatAppearance.BorderSize = 0;
            this.btnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.ForeColor = System.Drawing.Color.White;
            this.btnIngresos.Location = new System.Drawing.Point(75, 296);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(139, 44);
            this.btnIngresos.TabIndex = 5;
            this.btnIngresos.Text = "Ingresos";
            this.btnIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresos.UseVisualStyleBackColor = true;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(75, 368);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(139, 44);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(75, 156);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(113, 44);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Black;
            this.LTitulo.Location = new System.Drawing.Point(53, 42);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(226, 26);
            this.LTitulo.TabIndex = 9;
            this.LTitulo.Text = "Dashboard Principal";
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.White;
            this.PanelSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSuperior.Controls.Add(this.pbConfiguracion);
            this.PanelSuperior.Controls.Add(this.labelUsuario);
            this.PanelSuperior.Controls.Add(this.labelRol);
            this.PanelSuperior.Controls.Add(this.pictureBoxuser);
            this.PanelSuperior.Controls.Add(this.LTitulo);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(226, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(1124, 100);
            this.PanelSuperior.TabIndex = 1;
            // 
            // pbConfiguracion
            // 
            this.pbConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.pbConfiguracion.Image = global::CapaPresentacion.Properties.Resources.ajustes;
            this.pbConfiguracion.Location = new System.Drawing.Point(1069, 33);
            this.pbConfiguracion.Name = "pbConfiguracion";
            this.pbConfiguracion.Size = new System.Drawing.Size(42, 37);
            this.pbConfiguracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConfiguracion.TabIndex = 13;
            this.pbConfiguracion.TabStop = false;
            this.pbConfiguracion.Click += new System.EventHandler(this.pbConfiguracion_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(895, 64);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(49, 15);
            this.labelUsuario.TabIndex = 12;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.Location = new System.Drawing.Point(894, 33);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(33, 19);
            this.labelRol.TabIndex = 11;
            this.labelRol.Text = "Rol";
            // 
            // pictureBoxuser
            // 
            this.pictureBoxuser.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxuser.Image = global::CapaPresentacion.Properties.Resources.circulo_de_usuario;
            this.pictureBoxuser.Location = new System.Drawing.Point(822, 33);
            this.pictureBoxuser.Name = "pictureBoxuser";
            this.pictureBoxuser.Size = new System.Drawing.Size(42, 37);
            this.pictureBoxuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxuser.TabIndex = 10;
            this.pictureBoxuser.TabStop = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelContenedor.Controls.Add(this.pbPrincipal);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(226, 100);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1124, 629);
            this.PanelContenedor.TabIndex = 11;
            // 
            // pbPrincipal
            // 
            this.pbPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPrincipal.Image = global::CapaPresentacion.Properties.Resources.logotaller;
            this.pbPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pbPrincipal.Name = "pbPrincipal";
            this.pbPrincipal.Size = new System.Drawing.Size(1122, 627);
            this.pbPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrincipal.TabIndex = 0;
            this.pbPrincipal.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.PanelLateral);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.PanelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbusuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcliente)).EndInit();
            this.panelCerrarseccion.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfiguracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxuser)).EndInit();
            this.PanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCerrarSeccion;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelCerrarseccion;
        private System.Windows.Forms.PictureBox pbusuarios;
        private System.Windows.Forms.PictureBox pbhistorial;
        private System.Windows.Forms.PictureBox pbIngresos;
        private System.Windows.Forms.PictureBox pbvehiculos;
        private System.Windows.Forms.PictureBox pbcliente;
        private System.Windows.Forms.PictureBox pictureBoxuser;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelRol;
        public System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox pbConfiguracion;
        private System.Windows.Forms.PictureBox pbPrincipal;
    }
}

