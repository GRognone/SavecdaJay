using BiblioControles;
using BiblioVirement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesControles2
{
    public partial class FormVirement : Form
    {
        private Virement virement; // initialisation de la classe metier Virement dans la Form. ici par exemple dans la Form  "FormVirement"

        public FormVirement()
        {
            InitializeComponent();

        }

        private void button_valider_Click(object sender, EventArgs e)
        {

            //reverifier tous les champs
            if (ControlesAEffectuer.NomAVerifier(textBox_nom.Text) &&
                ControlesAEffectuer.DateAVerifier(textBox_date.Text) &&
                 ControlesAEffectuer.MontantAVerifier(textBox_montant.Text) &&
                ControlesAEffectuer.CodePostalAVerifier(textBox_CP.Text))
            {
                //creer le virement=instancier
                // ne pas oublier de convertir les formats des attributs de la classe qui sont autres que string en string via les Parse

                virement = new Virement(textBox_nom.Text, DateTime.Parse(textBox_date.Text),
                float.Parse(textBox_montant.Text, CultureInfo.InvariantCulture),textBox_CP.Text); // culture info invariantCulturepermer de taper une virgule ou un point pour la decimale

                //instancier le form que l'on appelle Validation effectuées
                //..  = new ....
                //demander à la form de s'afficher maForm.ShowDialog();

                ValidationsEffectuees maValidation = new ValidationsEffectuees(virement); // instantiation de la Form "ValidationEffectuee" qui récupère les valeurs de la classe virement
                maValidation.ShowDialog();
            }
        }

        // controle de la validité des valeurs saisies dans les textBox.
        private void textBox_nom_TextChanged(object sender, EventArgs e)
        {
            if (!ControlesAEffectuer.NomAVerifier(textBox_nom.Text))
            {
                errorProvider_nom.SetError(textBox_nom, "Veuillez saisir des lettres maximum 30");
            }
            else
            {
                errorProvider_nom.SetError(textBox_nom, "");
            }
        }
        private void textBox_date_TextChanged(object sender, EventArgs e)
        {
            if (!ControlesAEffectuer.DateAVerifier(textBox_date.Text))
            {
                errorProvider_date.SetError(textBox_date, "Date saisie incorrecte respecter le format demandé");
            }
            else
            {
                errorProvider_date.SetError(textBox_date, "");
            }
        }
        private void textBox_montant_TextChanged(object sender, EventArgs e)
        {
            if (!ControlesAEffectuer.MontantAVerifier(textBox_montant.Text))
            {
                errorProvider_montant.SetError(textBox_montant, "Montant saisi incorrect saisissez un cifre de 10 caracteteres maximum suivi ou non d'une decimale à 2 chiffres");
            }
            else
            {
                errorProvider_montant.SetError(textBox_montant, "");
            }
        }
        private void textBox_CP_TextChanged(object sender, EventArgs e)
        {
            if (!ControlesAEffectuer.CodePostalAVerifier(textBox_CP.Text))
            {
                errorProvider_cp.SetError(textBox_CP, "Veuillez- saisir un code postal à 5 chiffres svp");
            }
            else
            {
                errorProvider_cp.SetError(textBox_CP, "");
            }
        }

        // Effacer les valeurs dans les textBox
        private void button_effacer_Click(object sender, EventArgs e)
        {
            textBox_nom.Clear();
            errorProvider_nom.SetError(textBox_nom, "");
            textBox_date.Clear();
            errorProvider_date.SetError(textBox_date, "");
            textBox_montant.Clear();
            errorProvider_montant.SetError(textBox_montant, "");
            textBox_CP.Clear();
            errorProvider_cp.SetError(textBox_CP, "");
        }

        // Fermenture de la FormVirement par clic sur la croix suivi d'un message de demande de confirmation.

        private void FormVirement_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Fin de l'application ?", "FIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

