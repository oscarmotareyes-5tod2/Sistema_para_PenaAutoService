using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteAtender : Form
    {
        public FrmReporteAtender()
        {
            InitializeComponent();
        }

        private void FrmReporteAtender_Load(object sender, EventArgs e)
        {

            this.RvAtender.RefreshReport();
        }

      
    }
}
