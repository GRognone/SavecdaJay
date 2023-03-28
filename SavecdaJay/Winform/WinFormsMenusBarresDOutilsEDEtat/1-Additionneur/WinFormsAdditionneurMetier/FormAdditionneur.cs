using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using ClassLibraryAddition;

namespace WinFormsAdditionneurMetier
{
    public partial class FormAdditionneur : Form
    {
        Addition addition;
        public FormAdditionneur()
        {
            InitializeComponent();
            addition = new Addition();
        }
        private void button_all_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            addition.AjouterNombre(int.Parse((string)b.Tag));
            this.textBox_Affichage.Text += b.Tag + "+";
        }
        private void button_Vider_Click(object sender, EventArgs e)
        {
            this.textBox_Affichage.Text = "";
            addition = new Addition();
        }
        private void button_Calculer_Click(object sender, EventArgs e)
        {
            this.textBox_Affichage.Text = addition.RecupererResultat() + "+";
        }
    }
}
