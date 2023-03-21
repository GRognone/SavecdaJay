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
            this.hScrollBar_Red.Value = maCouleur.R;
            this.numericUpDown_Red.Value = maCouleur.R;
            panel_Red.BackColor = Color.FromArgb((int)maCouleur.R, 0, 0);

            this.hScrollBar_Green.Value = maCouleur.G;
            this.numericUpDown_Green.Value = maCouleur.G;
            panel_Green.BackColor = Color.FromArgb(0, (int)maCouleur.G, 0);

            this.hScrollBar_Blue.Value = maCouleur.B;
            this.numericUpDown_Blue.Value = maCouleur.B;
            panel_Blue.BackColor = Color.FromArgb(0, 0, (int)maCouleur.B);

            panel_ColorResult.BackColor = maCouleur;
        }

        private void hScrollBar_Red_ValueChanged(object sender, EventArgs e)
        {
            maCouleur = Color.FromArgb(hScrollBar_Red.Value, maCouleur.G, maCouleur.B);
            MettreAjourIHM();
        }
        private void numericUpDown_Red_ValueChanged(object sender, EventArgs e)
        {
            maCouleur = Color.FromArgb((int)numericUpDown_Red.Value, maCouleur.G, maCouleur.B);
            MettreAjourIHM();
        }
        private void numericUpDown_Green_ValueChanged(object sender, EventArgs e)
        {
            maCouleur = Color.FromArgb(maCouleur.R, (int)numericUpDown_Green.Value, maCouleur.B);
            MettreAjourIHM();
        }
        private void hScrollBar_Green_ValueChanged(object sender, EventArgs e)
        {
            maCouleur = Color.FromArgb(maCouleur.R, this.hScrollBar_Green.Value, maCouleur.B);
            MettreAjourIHM();
        }
        private void hScrollBar_Blue_ValueChanged(object sender, EventArgs e)
        {
            maCouleur = Color.FromArgb(maCouleur.R, maCouleur.G, this.hScrollBar_Blue.Value);
            MettreAjourIHM();
        }
        private void numericUpDown_Blue_ValueChanged(object sender, EventArgs e)
        {
            maCouleur = Color.FromArgb(maCouleur.R, maCouleur.G, (int)numericUpDown_Blue.Value);
            MettreAjourIHM();
        }
        
    }
}
