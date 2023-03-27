using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAdditionneurBoutonsJoins
{
    public partial class FormAdditionneurTousBoutons : Form
    {
        int total;
        public FormAdditionneurTousBoutons()
        {
            total = 0;
            InitializeComponent();
        }
        private void button_All_Clic(object sender, EventArgs e)
        {
            Button b = sender as Button;
            this.textBox_Affichage.Text += b.Tag + "+";
            total += int.Parse((string)b.Tag);
        }
        private void button_Vider_Click(object sender, EventArgs e)
        {
            this.textBox_Affichage.Text = "";
            total = 0;
        }
        private void button_Calculer_Click(object sender, EventArgs e)
        {
            this.textBox_Affichage.Text += "=" + total + "+";
        }
    }
}
