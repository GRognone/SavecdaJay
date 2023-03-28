using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDefilements
{
    public partial class FormLesComposantDeDefilement : Form
    {
        public FormLesComposantDeDefilement()
        {
            InitializeComponent();
            panel_red.BackColor = Color.FromArgb(0, 0, 0);
            panel_green.BackColor = Color.FromArgb(0, 0, 0);
            panel_blue.BackColor = Color.FromArgb(0, 0, 0);
        }

        // gere le scroll rouge
        private void hScrollBar_Red_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_Red.Value = (int)hScrollBar_Red.Value;
            panel_red.BackColor = Color.FromArgb(hScrollBar_Red.Value, 0, 0);
        }
        // gere le numerique rouge
        private void numericUpDown_Red_ValueChanged(object sender, EventArgs e)
        {
            hScrollBar_Red.Value = (int)numericUpDown_Red.Value;
            panel_red.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, 0, 0);
            panel_colorResult.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, (int)numericUpDown_Green.Value, (int)numericUpDown_Blue.Value);
        }
        // gere le scroll vert
        private void hScrollBar_Green_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_Green.Value = (int)hScrollBar_Green.Value;
            panel_green.BackColor = Color.FromArgb(0, hScrollBar_Green.Value, 0);
        }
        // gere le numerique vert
        private void numericUpDown_Green_ValueChanged(object sender, EventArgs e)
        {
            hScrollBar_Green.Value = (int)numericUpDown_Green.Value;
            panel_green.BackColor = Color.FromArgb(0, (int)numericUpDown_Green.Value, 0);
            panel_colorResult.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, (int)numericUpDown_Green.Value, (int)numericUpDown_Blue.Value);
        }
        // gere le scroll bleu
        private void hScrollBar_Blue_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_Blue.Value = (int)hScrollBar_Blue.Value;
            panel_blue.BackColor = Color.FromArgb(0, 0, hScrollBar_Blue.Value);
        }
        // gere le numérique Bleu
        private void numericUpDown_Blue_ValueChanged(object sender, EventArgs e)
        {
            hScrollBar_Blue.Value = (int)numericUpDown_Blue.Value;
            panel_blue.BackColor = Color.FromArgb(0, 0, (int)numericUpDown_Blue.Value);
            panel_colorResult.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, (int)numericUpDown_Green.Value, (int)numericUpDown_Blue.Value);
        }
    }
}
