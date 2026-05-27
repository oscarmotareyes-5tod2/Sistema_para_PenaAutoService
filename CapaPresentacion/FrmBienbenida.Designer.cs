namespace CapaPresentacion
{
    partial class FrmBienbenida
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
            this.pbBienbenida = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBienbenida)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBienbenida
            // 
            this.pbBienbenida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBienbenida.Image = global::CapaPresentacion.Properties.Resources.logotaller;
            this.pbBienbenida.Location = new System.Drawing.Point(0, 0);
            this.pbBienbenida.Name = "pbBienbenida";
            this.pbBienbenida.Size = new System.Drawing.Size(1104, 729);
            this.pbBienbenida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBienbenida.TabIndex = 0;
            this.pbBienbenida.TabStop = false;
            // 
            // FrmBienbenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 729);
            this.Controls.Add(this.pbBienbenida);
            this.Name = "FrmBienbenida";
            this.Text = "FrmVehiculos";
            this.Load += new System.EventHandler(this.FrmBienbenida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBienbenida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBienbenida;
    }
}