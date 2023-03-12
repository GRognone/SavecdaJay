using BiblioControles;
using BibliOFormulaireBanque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesControles2
{
    public partial class LesControles : Form
    {


        public LesControles()
        {
            InitializeComponent();
        }
        private void LesControles_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Fin de l'application ?", "FIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_valider_Click(object sender, EventArgs e)
        {

        }
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
        private void button_effacer_Click(object sender, EventArgs e)
        {
            textBox_nom.Clear();
            errorProvider_nom.SetError(textBox_nom, "");
            textBox_date.Clear();
            errorProvider_date.SetError(textBox_date, "");
            textBox_montant.Clear();
            errorProvider_montant.SetError(textBox_montant, "");
            textBox_CP.Clear();
            errorProvider_date.SetError(textBox_CP, "");
        }

    }
}

