using LesControles2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WinFormsMenusBarresDOutilsEDEtat
{
    public partial class FormCreationFormulaire : Form
    {
        public int Compteur;
        public FormCreationFormulaire()
        {
            InitializeComponent();
            toolStripSplitButtonPhase3.DropDown = phase3ToolStripMenuItem.DropDown;// recupère les commande de phase 3 StripMenu.
            toolStripLabelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");// affiche date en temps reel en bas de la fenêtre.
            Compteur = 1;//initialisation du compteur de fenêtres
                         //lancement du login au demarrage
            FormLogin formulaireLogin2 = new FormLogin();
            formulaireLogin2.FormClosing += F_FormClosingInit;
            formulaireLogin2.ShowDialog();

            //this.Hide();
        }
        //ferme le Login Initial
        private void F_FormClosingInit(object? sender, FormClosingEventArgs e)
        {
            FormLogin formLoginInit = sender as FormLogin;
            if (formLoginInit.ConnectionValide())
            {
                this.Show();
                //DeverouillerIHM(); //pour deverouiller directement apres login
            }
            else
            {
                this.Close();
            }
        }
            private void DeverouillerIHM()
        {
            phase1ToolStripMenuItem.Enabled = true;
            phase2ToolStripMenuItem.Enabled = true;
            phase3ToolStripMenuItem.Enabled = true;
            fenêtresToolStripMenuItem.Enabled = true;
            toolStripSplitButtonPhase3.Enabled = true;
        }
        // passer par connection s'identifier
        private void sidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue dans votre programme de formulaire");
            DeverouillerIHM();
        }
        // possibilité de se connecter par s'identifier du toolstrip button
        private void toolStripButtonSIdentifier_Click(object sender, EventArgs e)
        {
            FormLogin formulaireLogin = new FormLogin();
            formulaireLogin.FormClosing += F_FormClosing;
            OuvrirFormulaire(formulaireLogin);
        }
        private void F_FormClosing(object? sender, FormClosingEventArgs e)
        {
            FormLogin formulaireLogin = sender as FormLogin;
            if (formulaireLogin.ConnectionValide())
            {
                DeverouillerIHM();
                this.Show();
            }
            else
            {
                this.Close();
            }
        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquez OK pour quitter l'application");
            Close();
        }
        #region FormsImportes
        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FormAdditionneur());
        }
        private void lesControlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FormVirement());
        }
        private void CheckBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FormSaisieTextePhase3ChekBoxBtRadio());
            //attention nous initialisons ici la Formsaisie au lieu de la FormLesDifferentsObjetsGraphiques
            //cela permet de saisir le texte dans la textbox 'saisie' et le récuperer dans la textBox de 'differents objets graphiques'.
        }
        private void opBasesListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FormLes_listesEtLeurPropriete());
        }
        private void listBoxEtComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new Listes_et_ComboBox());
        }
        private void DefilementToolStripMenuItem_Click(object sender, EventArgs e) //1er facon d'écrire.
        {
            OuvrirFormulaire(new FormCouleurs());
        }
        private void syntheseToolStripMenuItem_Click(object sender, EventArgs e) => OuvrirFormulaire(new FormEmprunt());//2eme façon d'écrire
        #endregion
        #region LabelStrip indiquant les derniers evenements
        //creation une methode générique qui s'applique sur n'importe quelle form.
        private void OuvrirFormulaire(Form f)
        {
            f.Load += new EventHandler(IndicationDuDernierEvenement);
            f.MdiParent = this; /// positionne une form dans la form Mdi
            f.Show();// la montre dans le Mdi
            f.FormClosed += new FormClosedEventHandler(ChangerLabelALaFermetureDuneFenetre);
            f.Text += "N° " + Compteur;
            Compteur++;
        }
        private void ChangerLabelALaFermetureDuneFenetre(object? sender, FormClosedEventArgs e) // objet? veut dire que l'objet est nullable.
        {
            toolStripLabelDerniereOperation.Text = "Fermeture de " + ((Form)sender).Text;
        }
        private void IndicationDuDernierEvenement(object? sender, EventArgs e)
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
