namespace CapaPresentacion
{
    partial class FrmIngreso
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
            this.dgvIngresos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIngresos
            // 
            this.dgvIngresos.AllowUserToAddRows = false;
            this.dgvIngresos.AllowUserToDeleteRows = false;
            this.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresos.Location = new System.Drawing.Point(81, 54);
            this.dgvIngresos.Name = "dgvIngresos";
            this.dgvIngresos.Size = new System.Drawing.Size(944, 409);
            this.dgvIngresos.TabIndex = 0;
            this.dgvIngresos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngresos_CellContentClick);
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 729);
            this.Controls.Add(this.dgvIngresos);
            this.Name = "FrmIngreso";
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            this.Click += new System.EventHandler(this.FrmIngreso_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIngresos;
    }
}