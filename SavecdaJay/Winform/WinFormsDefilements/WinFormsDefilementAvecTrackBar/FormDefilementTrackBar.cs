using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDefilementAvecTrackBar
{
    public partial class FormDefilementTrackBar : Form
    {
        public FormDefilementTrackBar()
        {
            InitializeComponent();
            panel_Result.BackColor = Color.FromArgb(0, 0, 0);
            panel_Red.BackColor = Color.FromArgb(0, 0, 0);
            panel_Green.BackColor = Color.FromArgb(0, 0, 0);
            panel_Blue.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void trackBar_Red_Scroll(object sender, EventArgs e)
        {
            numericUpDown_Red.Value = (int)trackBar_Red.Value;
            hScrollBar_Red.Value = (int)trackBar_Red.Value;
            panel_Red.BackColor = Color.FromArgb(trackBar_Red.Value,0,0);
            panel_Result.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, (int)numericUpDown_Green.Value, (int)numericUpDown_Blue.Value);
        }

        private void hScrollBar_Red_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDown_Red.Value = (int)hScrollBar_Red.Value;
            trackBar_Red.Value = (int)hScrollBar_Red.Value;
            panel_Red.BackColor = Color.FromArgb(hScrollBar_Red.Value, 0, 0);
            panel_Result.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, (int)numericUpDown_Green.Value, (int)numericUpDown_Blue.Value);
        }

        private void numericUpDown_Red_ValueChanged(object sender, EventArgs e)
        {
            trackBar_Red.Value = (int)numericUpDown_Red.Value;
            hScrollBar_Red.Value = (int)numericUpDown_Red.Value;
            panel_Red.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, 0, 0);
            panel_Result.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, (int) numericUpDown_Green.Value, (int)numericUpDown_Blue.Value);
        }

        private void trackBar_Green_Scroll(object sender, EventArgs e)
        {
            numericUpDown_Green.Value = (int)trackBar_Green.Value;
            hScrollBar_Green.Value = (int)trackBar_Green.Value;
            panel_Green.BackColor = Color.FromArgb(0,trackBar_Green.Value, 0);
            panel_Result.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, (int)numericUpDown_Green.Value, (int)numericUpDown_Blue.Value);
        }

        private void hScrollBar_Green_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDown_Green.Value = (int)hScrollBar_Green.Value;
            trackBar_Green.Value = (int)hScrollBar_Green.Value;
            panel_Green.BackColor = Color.FromArgb(0,hScrollBar_Green.Value, 0);
            panel_Result.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, (int)numericUpDown_Green.Value, (int)numericUpDown_Blue.Value);
        }

        private void numericUpDown_Green_ValueChanged(object sender, EventArgs e)
        {
            trackBar_Green.Value = (int)numericUpDown_Green.Value;
            hScrollBar_Green.Value = (int)numericUpDown_Green.Value;
            panel_Green.BackColor = Color.FromArgb(0, (int)numericUpDown_Green.Value, 0);
            panel_Result.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, (int)numericUpDown_Green.Value, (int)numericUpDown_Blue.Value);
        }

        private void trackBar_Blue_Scroll(object sender, EventArgs e)
        {
            numericUpDown_Blue.Value = (int)trackBar_Blue.Value;
            hScrollBar_Blue.Value = (int)trackBar_Blue.Value;
            panel_Blue.BackColor = Color.FromArgb(0, 0,trackBar_Blue.Value);
            panel_Result.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, (int)numericUpDown_Green.Value, (int)numericUpDown_Blue.Value);
        }

        private void hScrollBar_Blue_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDown_Blue.Value = (int)hScrollBar_Blue.Value;
            trackBar_Blue.Value = (int)hScrollBar_Blue.Value;
            panel_Blue.BackColor = Color.FromArgb(0, 0,hScrollBar_Blue.Value);
            panel_Result.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, (int)numericUpDown_Green.Value, (int)numericUpDown_Blue.Value);
        }

        private void numericUpDown_Blue_ValueChanged(object sender, EventArgs e)
        {
            trackBar_Blue.Value = (int)numericUpDown_Blue.Value;
            hScrollBar_Blue.Value = (int)numericUpDown_Blue.Value;
            panel_Blue.BackColor = Color.FromArgb(0, 0, (int)numericUpDown_Blue.Value);
            panel_Result.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, (int)numericUpDown_Green.Value, (int)numericUpDown_Blue.Value);
        }
    }
}
