using LesControles2;
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
using WinFormDefilementCondense;
using WinFormsAdditionneurMetier;
using WinFormsAppLesListesComboBox;
using WinFormsLesDifferentsObjetsGraphiques;
using WinFormsOperationBaseListBox;
using WinFormsSynthese;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsMenusBarresDOutilsEDEtat
{
    public partial class FormCreationFormulaire : Form
    {
        public FormCreationFormulaire()
        {
            InitializeComponent();
            toolStripSplitButtonPhase3.DropDown = phase3ToolStripMenuItem.DropDown;// recupère les commande de phase 3 StripMenu.
            toolStripLabelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");// affiche data en temps reel en bas de la fenêtre.
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
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquez OK pour quitter l'application");
            Close();
        }
        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdditionneur formAddition = new FormAdditionneur();
            formAddition.Show();
        }
        private void lesControlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVirement formVirement = new FormVirement();
            formVirement.Show();
        }

        private void CheckBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLesDifferentsObjetsGraphiques formObjetGraph = new FormLesDifferentsObjetsGraphiques();
            formObjetGraph.Show();
        }
        private void opBasesListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLes_listesEtLeurPropriete formListbox = new FormLes_listesEtLeurPropriete();
            formListbox.Show();
        }
        private void listBoxEtComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listes_et_ComboBox formListboxCombobox = new Listes_et_ComboBox();
            formListboxCombobox.Show();
        }
        private void DefilementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCouleurs formCouleurs = new FormCouleurs();
            formCouleurs.Show();
        }
        private void syntheseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmprunt formEmprunt = new FormEmprunt();
            formEmprunt.Show();
        }
    }
}
