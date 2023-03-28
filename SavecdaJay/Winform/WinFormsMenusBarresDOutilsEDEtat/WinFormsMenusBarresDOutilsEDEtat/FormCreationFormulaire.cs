using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsMenusBarresDOutilsEDEtat
{
    public partial class FormCreationFormulaire : Form
    {
        public FormCreationFormulaire()
        {
            InitializeComponent();

            toolStripSplitButtonPhase3.DropDown = phase3ToolStripMenuItem.DropDown;// recupère les commande de phase 3 StripMenu
            toolStripLabelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //toolStripLabelDerniereOperation = ultima;
        }

        private void phase1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phase2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phase3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fenêtresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue dans votre programme de formulaire");
            phase1ToolStripMenuItem.Enabled = true;
            phase2ToolStripMenuItem.Enabled = true;
            phase3ToolStripMenuItem.Enabled = true;
            fenêtresToolStripMenuItem.Enabled = true;
            toolStripButtonSIdentifier.Enabled = true;
            toolStripSplitButtonPhase3.Enabled = true;
        }
    }
}
