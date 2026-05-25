using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public class ThemeManager
    {
        public static void AplicarTemaOscuro(Form form,Color colorPrincipal)
        {
            form.BackColor = Color.FromArgb(30, 30, 30);
            form.ForeColor = Color.White;

            foreach (Control control in form.Controls)
            {
                AplicarEstiloControl(control, colorPrincipal);
            }
        }

        private static void AplicarEstiloControl(Control control,Color colorPrincipal)
        {
            // BOTONES
            if (control is Button btn)
            {
                btn.BackColor = colorPrincipal;
                btn.ForeColor = Color.White;

                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }

            // TEXTBOX
            else if (control is TextBox txt)
            {
                txt.BackColor = Color.FromArgb(45, 45, 45);
                txt.ForeColor = Color.White;
                txt.BorderStyle = BorderStyle.FixedSingle;
            }

            // COMBOBOX
            else if (control is ComboBox cmb)
            {
                cmb.BackColor = Color.FromArgb(45, 45, 45);
                cmb.ForeColor = Color.White;
            }

            // LABEL
            else if (control is Label lbl)
            {
                lbl.ForeColor = Color.White;
            }

            // DATAGRIDVIEW
            else if (control is DataGridView dgv)
            {
                dgv.BackgroundColor = Color.FromArgb(40, 40, 40);

                dgv.DefaultCellStyle.BackColor =
                    Color.FromArgb(45, 45, 45);

                dgv.DefaultCellStyle.ForeColor =
                    Color.White;

                dgv.ColumnHeadersDefaultCellStyle.BackColor =colorPrincipal;

                dgv.ColumnHeadersDefaultCellStyle.ForeColor =
                    Color.White;

                dgv.EnableHeadersVisualStyles = false;
            }

            // PANEL
            else if (control is Panel pnl)
            {
                pnl.BackColor = Color.FromArgb(35, 35, 35);
            }

            // RECURSIVO
            foreach (Control hijo in control.Controls)
            {
                AplicarEstiloControl(hijo, colorPrincipal);
            }

        }

        public static Color ObtenerColorPrincipal(string color)
        {
            switch (color)
            {
                case "Rojo":
                    return Color.DarkRed;

                case "Azul":
                    return Color.FromArgb(0, 120, 215);

                case "Verde":
                    return Color.SeaGreen;

                case "Negro":
                    return Color.Black;

                default:
                    return Color.DarkRed;
            }
        }
    }
}
