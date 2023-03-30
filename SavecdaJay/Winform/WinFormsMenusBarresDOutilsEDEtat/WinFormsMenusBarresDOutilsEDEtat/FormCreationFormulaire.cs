using LesControles2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsMenusBarresDOutilsEDEtat
{
    public partial class FormCreationFormulaire : Form
    {
        public int CompteurAddition;
        public FormCreationFormulaire()
        {
            InitializeComponent();
            toolStripSplitButtonPhase3.DropDown = phase3ToolStripMenuItem.DropDown;// recupère les commande de phase 3 StripMenu.
            toolStripLabelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");// affiche date en temps reel en bas de la fenêtre.
            //toolStripLabelDerniereOperation = 
            CompteurAddition = 0;
        }
        private void DeverouillerIHM()
        {
            MessageBox.Show("Bienvenue dans votre programme de formulaire");
            phase1ToolStripMenuItem.Enabled = true;
            phase2ToolStripMenuItem.Enabled = true;
            phase3ToolStripMenuItem.Enabled = true;
            fenêtresToolStripMenuItem.Enabled = true;
            toolStripSplitButtonPhase3.Enabled = true;
        }
        // passer par connection s'identifier
        private void sidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeverouillerIHM();
        }
        // possibilité de se connecter par s'identifier du toolstrip button
        private void toolStripButtonSIdentifier_Click(object sender, EventArgs e)
        {
            DeverouillerIHM();
        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquez OK pour quitter l'application");
            Close();
        }
        #region FormsImportes
        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdditionneur formAddition = new FormAdditionneur();
            formAddition.Text += "N° " + CompteurAddition;
            formAddition.MdiParent = this; // positionne notre form dans la form Mdi
            formAddition.Show();
            if (formAddition != new FormAdditionneur())
            {
                CompteurAddition++;  
            }
            else
            {
                CompteurAddition--;
            }


        }
        private void lesControlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVirement formVirement = new FormVirement();
            formVirement.MdiParent = this;// positionne notre form dans la form Mdi
            formVirement.Show();
        }
        private void CheckBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //attention nous initialisons ici la Formsaisie au lieu de la FormLesDifferentsObjetsGraphiques
            //cela permet de saisit le texte dans 'saisie' et le récuperer dans 'differents objets graphiques'.
            FormSaisieTextePhase3ChekBoxBtRadio formObjetGraph = new FormSaisieTextePhase3ChekBoxBtRadio();
            formObjetGraph.MdiParent = this;// positionne notre form dans la form Mdi
            formObjetGraph.Show();
        }
        private void opBasesListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLes_listesEtLeurPropriete formListbox = new FormLes_listesEtLeurPropriete();
            formListbox.MdiParent = this;// positionne notre form dans la form Mdi
            formListbox.Show();
        }
        private void listBoxEtComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listes_et_ComboBox formListboxCombobox = new Listes_et_ComboBox();
            formListboxCombobox.MdiParent = this;// positionne notre form dans la form Mdi
            formListboxCombobox.Show();
        }
        private void DefilementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FormCouleurs());
            /* FormCouleurs formCouleurs = new FormCouleurs();
             formCouleurs.MdiParent = this;// positionne notre form dans la form Mdi
             formCouleurs.Show();*/
        }
        private void syntheseToolStripMenuItem_Click(object sender, EventArgs e) => OuvrirFormulaire(new FormEmprunt());
        /*{
            FormEmprunt formEmprunt = new FormEmprunt();
            formEmprunt.MdiParent = this;// positionne notre form dans la form Mdi
            formEmprunt.Show();
        }*/

        private void OuvrirFormulaire(Form f)
        {
            f.Load += new EventHandler(ChoseAuChargement);
            f.MdiParent = this;
            f.Show();
            f.FormClosed += new FormClosedEventHandler(ChangerLabelALaFermetureDuneFenetre);

        }

        private void ChangerLabelALaFermetureDuneFenetre(object? sender, FormClosedEventArgs e)
        {
            toolStripLabelDerniereOperation.Text = "Fermeture de " + ((Form)sender).Text;
        }

        private void ChoseAuChargement(object? sender, EventArgs e)
        {
            toolStripLabelDerniereOperation.Text = "Ouverture de " + ((Form)sender).Text;
        }
        #endregion
        #region fenetre
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        #endregion
    }
}
