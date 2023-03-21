using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDefilementCondense
{

    public partial class FormCouleurs : Form
    {
        System.Drawing.Color maCouleur;
        public FormCouleurs()
        {
            InitializeComponent();
            maCouleur = Color.FromArgb(125, 63,100);
            MettreAjourIHM();
        }
        private void MettreAjourIHM()
        {
            // 10 lignes de code max
            this.numericUpDown_Red.Value = maCouleur.R;
            panel_Red.BackColor = Color.FromArgb((int)maCouleur.R, 0, 0);

            this.numericUpDown_Green.Value = maCouleur.G;
            panel_Green.BackColor = Color.FromArgb(0, (int)maCouleur.G, 0);

            this.numericUpDown_Blue.Value = maCouleur.B;
            panel_Blue.BackColor = Color.FromArgb(0, 0, (int)maCouleur.B);

            panel_ColorResult.BackColor = maCouleur;
        }

        private void hScrollBar_Red_Scroll(object sender, ScrollEventArgs e)
        {
            maCouleur = Color.FromArgb((int)e.NewValue, maCouleur.G , maCouleur.B);
            MettreAjourIHM();
        }

        private void numericUpDown_Red_ValueChanged(object sender, EventArgs e)
        {
            hScrollBar_Red.Value = (int)numericUpDown_Red.Value;
            panel_Red.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, 0, 0);
            panel_ColorResult.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, (int)numericUpDown_Green.Value, (int)numericUpDown_Blue.Value);
        }

        private void hScrollBar_Green_Scroll(object sender, ScrollEventArgs e)
        {
            maCouleur = Color.FromArgb(maCouleur.R,(int)e.NewValue, maCouleur.B);
            MettreAjourIHM();
        }

        private void numericUpDown_Green_ValueChanged(object sender, EventArgs e)
        {
            hScrollBar_Green.Value = (int)numericUpDown_Green.Value;
            panel_Green.BackColor = Color.FromArgb(0, (int)numericUpDown_Green.Value, 0);
            panel_ColorResult.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, (int)numericUpDown_Green.Value, (int)numericUpDown_Blue.Value);
        }

        private void hScrollBar_Blue_Scroll(object sender, ScrollEventArgs e)
        {
            maCouleur = Color.FromArgb(maCouleur.R, maCouleur.G, (int)e.NewValue);
            MettreAjourIHM();
        }

        private void numericUpDown_Blue_ValueChanged(object sender, EventArgs e)
        {
            hScrollBar_Blue.Value = (int)numericUpDown_Blue.Value;
            panel_Blue.BackColor = Color.FromArgb(0, 0, (int)numericUpDown_Blue.Value);
            panel_ColorResult.BackColor = Color.FromArgb((int)numericUpDown_Red.Value, (int)numericUpDown_Green.Value, (int)numericUpDown_Blue.Value);
        }
    }
}
