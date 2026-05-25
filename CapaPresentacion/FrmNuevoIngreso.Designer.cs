namespace CapaPresentacion
{
    partial class FrmNuevoIngreso
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
            this.panelDcliente = new System.Windows.Forms.Panel();
            this.labelsuntituloDC = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.panelTDcliente = new System.Windows.Forms.Panel();
            this.labelDcliente = new System.Windows.Forms.Label();
            this.panelDvehiculo = new System.Windows.Forms.Panel();
            this.txtFalla = new System.Windows.Forms.TextBox();
            this.labelFalla = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.labelAño = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDvehiculo = new System.Windows.Forms.Label();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelEncabezadoNingreso = new System.Windows.Forms.Panel();
            this.pbEncabezado = new System.Windows.Forms.PictureBox();
            this.labelEncabezado = new System.Windows.Forms.Label();
            this.panelDcliente.SuspendLayout();
            this.panelTDcliente.SuspendLayout();
            this.panelDvehiculo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelEncabezadoNingreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEncabezado)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDcliente
            // 
            this.panelDcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDcliente.Controls.Add(this.labelsuntituloDC);
            this.panelDcliente.Controls.Add(this.txtDireccion);
            this.panelDcliente.Controls.Add(this.labelDireccion);
            this.panelDcliente.Controls.Add(this.txtCorreo);
            this.panelDcliente.Controls.Add(this.labelCorreo);
            this.panelDcliente.Controls.Add(this.txtTelefono);
            this.panelDcliente.Controls.Add(this.labelTelefono);
            this.panelDcliente.Controls.Add(this.txtNombre);
            this.panelDcliente.Controls.Add(this.labelNombre);
            this.panelDcliente.Controls.Add(this.panelTDcliente);
            this.panelDcliente.Location = new System.Drawing.Point(71, 120);
            this.panelDcliente.Name = "panelDcliente";
            this.panelDcliente.Size = new System.Drawing.Size(802, 203);
            this.panelDcliente.TabIndex = 0;
            // 
            // labelsuntituloDC
            // 
            this.labelsuntituloDC.AutoSize = true;
            this.labelsuntituloDC.ForeColor = System.Drawing.Color.Gray;
            this.labelsuntituloDC.Location = new System.Drawing.Point(3, 51);
            this.labelsuntituloDC.Name = "labelsuntituloDC";
            this.labelsuntituloDC.Size = new System.Drawing.Size(182, 13);
            this.labelsuntituloDC.TabIndex = 2;
            this.labelsuntituloDC.Text = "El gmail y la direccion son opcionales";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(516, 135);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(166, 45);
            this.txtDireccion.TabIndex = 9;
            this.txtDireccion.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(437, 137);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(78, 19);
            this.labelDireccion.TabIndex = 8;
            this.labelDireccion.Text = "Dirección:";
            this.labelDireccion.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(152, 135);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(166, 20);
            this.txtCorreo.TabIndex = 7;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(92, 137);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(54, 19);
            this.labelCorreo.TabIndex = 6;
            this.labelCorreo.Text = "Gmail:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(509, 84);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(166, 20);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(431, 85);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(72, 19);
            this.labelTelefono.TabIndex = 4;
            this.labelTelefono.Text = "Telefóno:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(152, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(166, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(78, 86);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(68, 19);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:";
            // 
            // panelTDcliente
            // 
            this.panelTDcliente.BackColor = System.Drawing.Color.DarkRed;
            this.panelTDcliente.Controls.Add(this.labelDcliente);
            this.panelTDcliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTDcliente.Location = new System.Drawing.Point(0, 0);
            this.panelTDcliente.Name = "panelTDcliente";
            this.panelTDcliente.Size = new System.Drawing.Size(800, 48);
            this.panelTDcliente.TabIndex = 0;
            // 
            // labelDcliente
            // 
            this.labelDcliente.AutoSize = true;
            this.labelDcliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDcliente.ForeColor = System.Drawing.Color.White;
            this.labelDcliente.Location = new System.Drawing.Point(16, 16);
            this.labelDcliente.Name = "labelDcliente";
            this.labelDcliente.Size = new System.Drawing.Size(155, 22);
            this.labelDcliente.TabIndex = 1;
            this.labelDcliente.Text = "Datos del Cliente:";
            // 
            // panelDvehiculo
            // 
            this.panelDvehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDvehiculo.Controls.Add(this.txtFalla);
            this.panelDvehiculo.Controls.Add(this.labelFalla);
            this.panelDvehiculo.Controls.Add(this.txtAnio);
            this.panelDvehiculo.Controls.Add(this.labelAño);
            this.panelDvehiculo.Controls.Add(this.txtMarca);
            this.panelDvehiculo.Controls.Add(this.labelMarca);
            this.panelDvehiculo.Controls.Add(this.txtModelo);
            this.panelDvehiculo.Controls.Add(this.labelModelo);
            this.panelDvehiculo.Controls.Add(this.txtPlaca);
            this.panelDvehiculo.Controls.Add(this.panel2);
            this.panelDvehiculo.Controls.Add(this.labelPlaca);
            this.panelDvehiculo.Location = new System.Drawing.Point(70, 338);
            this.panelDvehiculo.Name = "panelDvehiculo";
            this.panelDvehiculo.Size = new System.Drawing.Size(802, 279);
            this.panelDvehiculo.TabIndex = 1;
            // 
            // txtFalla
            // 
            this.txtFalla.Location = new System.Drawing.Point(495, 105);
            this.txtFalla.Multiline = true;
            this.txtFalla.Name = "txtFalla";
            this.txtFalla.Size = new System.Drawing.Size(209, 144);
            this.txtFalla.TabIndex = 10;
            // 
            // labelFalla
            // 
            this.labelFalla.AutoSize = true;
            this.labelFalla.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFalla.Location = new System.Drawing.Point(524, 81);
            this.labelFalla.Name = "labelFalla";
            this.labelFalla.Size = new System.Drawing.Size(138, 19);
            this.labelFalla.TabIndex = 18;
            this.labelFalla.Text = "Motivo de Ingreso:";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(151, 229);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(60, 20);
            this.txtAnio.TabIndex = 17;
            // 
            // labelAño
            // 
            this.labelAño.AutoSize = true;
            this.labelAño.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAño.Location = new System.Drawing.Point(77, 228);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(41, 19);
            this.labelAño.TabIndex = 16;
            this.labelAño.Text = "Año:";
            this.labelAño.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(151, 146);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(128, 20);
            this.txtMarca.TabIndex = 15;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(77, 148);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(59, 19);
            this.labelMarca.TabIndex = 14;
            this.labelMarca.Text = "Marca:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(151, 189);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(144, 20);
            this.txtModelo.TabIndex = 13;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(77, 191);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(66, 19);
            this.labelModelo.TabIndex = 12;
            this.labelModelo.Text = "Modelo:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(151, 103);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(88, 20);
            this.txtPlaca.TabIndex = 11;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.labelDvehiculo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 48);
            this.panel2.TabIndex = 0;
            // 
            // labelDvehiculo
            // 
            this.labelDvehiculo.AutoSize = true;
            this.labelDvehiculo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDvehiculo.ForeColor = System.Drawing.Color.White;
            this.labelDvehiculo.Location = new System.Drawing.Point(16, 18);
            this.labelDvehiculo.Name = "labelDvehiculo";
            this.labelDvehiculo.Size = new System.Drawing.Size(166, 22);
            this.labelDvehiculo.TabIndex = 1;
            this.labelDvehiculo.Text = "Datos del Vehiculo:";
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaca.Location = new System.Drawing.Point(77, 102);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(50, 19);
            this.labelPlaca.TabIndex = 10;
            this.labelPlaca.Text = "Placa:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkRed;
            this.btnRegistrar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(108, 653);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(322, 40);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar Ingreso";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(503, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelEncabezadoNingreso
            // 
            this.panelEncabezadoNingreso.BackColor = System.Drawing.Color.DarkRed;
            this.panelEncabezadoNingreso.Controls.Add(this.pbEncabezado);
            this.panelEncabezadoNingreso.Controls.Add(this.labelEncabezado);
            this.panelEncabezadoNingreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezadoNingreso.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezadoNingreso.Name = "panelEncabezadoNingreso";
            this.panelEncabezadoNingreso.Size = new System.Drawing.Size(979, 71);
            this.panelEncabezadoNingreso.TabIndex = 12;
            // 
            // pbEncabezado
            // 
            this.pbEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.pbEncabezado.Image = global::CapaPresentacion.Properties.Resources.bandeja_de_entrada__1_;
            this.pbEncabezado.Location = new System.Drawing.Point(348, 12);
            this.pbEncabezado.Name = "pbEncabezado";
            this.pbEncabezado.Size = new System.Drawing.Size(42, 37);
            this.pbEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEncabezado.TabIndex = 3;
            this.pbEncabezado.TabStop = false;
            // 
            // labelEncabezado
            // 
            this.labelEncabezado.AutoSize = true;
            this.labelEncabezado.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncabezado.ForeColor = System.Drawing.Color.White;
            this.labelEncabezado.Location = new System.Drawing.Point(396, 23);
            this.labelEncabezado.Name = "labelEncabezado";
            this.labelEncabezado.Size = new System.Drawing.Size(167, 26);
            this.labelEncabezado.TabIndex = 2;
            this.labelEncabezado.Text = "Nuevo Ingreso:";
            // 
            // FrmNuevoIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(979, 729);
            this.Controls.Add(this.panelEncabezadoNingreso);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.panelDvehiculo);
            this.Controls.Add(this.panelDcliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevoIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevoIngreso";
            this.Load += new System.EventHandler(this.FrmNuevoIngreso_Load);
            this.panelDcliente.ResumeLayout(false);
            this.panelDcliente.PerformLayout();
            this.panelTDcliente.ResumeLayout(false);
            this.panelTDcliente.PerformLayout();
            this.panelDvehiculo.ResumeLayout(false);
            this.panelDvehiculo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelEncabezadoNingreso.ResumeLayout(false);
            this.panelEncabezadoNingreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEncabezado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDcliente;
        private System.Windows.Forms.Panel panelTDcliente;
        private System.Windows.Forms.Label labelDcliente;
        private System.Windows.Forms.Panel panelDvehiculo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDvehiculo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelsuntituloDC;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.TextBox txtFalla;
        private System.Windows.Forms.Label labelFalla;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelEncabezadoNingreso;
        private System.Windows.Forms.Label labelEncabezado;
        private System.Windows.Forms.PictureBox pbEncabezado;
    }
}