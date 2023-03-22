using ClassEmprunt;
using ClassLibrary_Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSynthese
{
    public partial class FormEmprunt : Form
    {
        private Emprunt emprunt1;

        public FormEmprunt()
        {
            InitializeComponent();

            
        }
        private void textBox_nom_TextChanged(object sender, EventArgs e)
        {
            if (!Controles.Controle_Saisie_Nom(textBox_nom.Text))
            {
                errorProvider_nom.SetError(textBox_nom, "Saisir uniquement des lettres (30 maximum sauf si c'est nom composés),si c'est un nom composé 15 lettres avant un '-' puis suivi d'un maximum 15 lettres.");
            }
            else
            {
                errorProvider_nom.SetError(textBox_nom, "");
            }
        }
        private void textBox_capita_emprunte_TextChanged(object sender, EventArgs e)
        {
            if (!Controles.Controle_Saisie_Capital_Emptrunt(textBox_capita_emprunte.Text))
            {
                errorProvider_capital.SetError(textBox_capita_emprunte, "Saisir uniquement des chiffres maximum 10");
            }
            else
            {
                errorProvider_capital.SetError(textBox_capita_emprunte, "");
            }
        }
        private void label_Duree_en_mois_Click(object sender, EventArgs e)
        {

        }
        private void hScrollBar_duree_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void listBox_periodicite_rembs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label_nb_remboursements_Click(object sender, EventArgs e)
        {

        }
        private void radioButton_interet_7_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton_interet_8_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton_interet_9_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label_montant_remb_periodicite_Click(object sender, EventArgs e)
        {

        }
        private void button_ok_Click(object sender, EventArgs e)
        {

        }
        private void button_annuler_Click(object sender, EventArgs e)
        {

        }
    }
}
