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
            this.labelBienbenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBienbenida
            // 
            this.labelBienbenida.AutoSize = true;
            this.labelBienbenida.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienbenida.Location = new System.Drawing.Point(356, 344);
            this.labelBienbenida.Name = "labelBienbenida";
            this.labelBienbenida.Size = new System.Drawing.Size(393, 40);
            this.labelBienbenida.TabIndex = 12;
            this.labelBienbenida.Text = "¡Bienvenido/a al Sistema!";
            // 
            // FrmBienbenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 729);
            this.Controls.Add(this.labelBienbenida);
            this.Name = "FrmBienbenida";
            this.Text = "FrmVehiculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienbenida;
    }
}