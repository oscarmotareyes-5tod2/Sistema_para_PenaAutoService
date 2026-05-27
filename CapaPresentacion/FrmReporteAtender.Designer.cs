namespace CapaPresentacion
{
    partial class FrmReporteAtender
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
            this.RvAtender = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RvAtender
            // 
            this.RvAtender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RvAtender.Location = new System.Drawing.Point(0, 0);
            this.RvAtender.Name = "RvAtender";
            this.RvAtender.ServerReport.BearerToken = null;
            this.RvAtender.Size = new System.Drawing.Size(800, 450);
            this.RvAtender.TabIndex = 0;
            // 
            // FrmReporteAtender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RvAtender);
            this.Name = "FrmReporteAtender";
            this.Text = "FrmReporteAtender";
            this.Load += new System.EventHandler(this.FrmReporteAtender_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RvAtender;
    }
}