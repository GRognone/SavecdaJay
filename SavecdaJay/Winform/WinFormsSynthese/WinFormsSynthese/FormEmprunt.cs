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
            emprunt1 = new Emprunt("", 0, 1, Emprunt.EnumPeriodicite.Mensuel, 0.07F);
            listBox_periodicite_rembs.Items.AddRange(new string[] { "Mensuel", "Bimestriel", "Trimestriel", "Semestriel", "Annuelle" });
            MiseAJourIHM();
        }
        #region IHM
        private void MiseAJourIHM()
        {
            //saisie capital
            textBox_capital_emprunte.Text = emprunt1.CapitalEmprunte.ToString();

            //choix duree scrollbar
            hScrollBar_duree.Value = emprunt1.DureeEmpruntMois;
            label_montant_remb_periodicite.Text = emprunt1.DureeEmpruntMois.ToString();

            //choix periodicite
            if (emprunt1.PeriodiciteRemboursement == Emprunt.EnumPeriodicite.Mensuel)
            {
                listBox_periodicite_rembs.SelectedIndex = 0;
                hScrollBar_duree.SmallChange = 1;
                hScrollBar_duree.LargeChange = 1;
                hScrollBar_duree.Minimum = 1;
            }
            else if (emprunt1.PeriodiciteRemboursement == Emprunt.EnumPeriodicite.Bimestriel)
            {
                listBox_periodicite_rembs.SelectedIndex = 1;
                hScrollBar_duree.SmallChange = 2;
                hScrollBar_duree.LargeChange = 2;
                hScrollBar_duree.Minimum = 2;
            }
            else if (emprunt1.PeriodiciteRemboursement == Emprunt.EnumPeriodicite.Trimestriel)
            {
                listBox_periodicite_rembs.SelectedIndex = 2;
                hScrollBar_duree.SmallChange = 3;
                hScrollBar_duree.LargeChange = 3;
                hScrollBar_duree.Minimum = 3;

            }
            else if (emprunt1.PeriodiciteRemboursement == Emprunt.EnumPeriodicite.Semestriel)
            {
                listBox_periodicite_rembs.SelectedIndex = 3;
                hScrollBar_duree.SmallChange = 6;
                hScrollBar_duree.LargeChange = 6;
                hScrollBar_duree.Minimum = 6;
            }
            else if (emprunt1.PeriodiciteRemboursement == Emprunt.EnumPeriodicite.Annuelle)
            {
                listBox_periodicite_rembs.SelectedIndex = 4;
                hScrollBar_duree.SmallChange = 12;
                hScrollBar_duree.LargeChange = 12;
                hScrollBar_duree.Minimum = 12;
            }
            if (label_Duree_en_mois.Text != hScrollBar_duree.Value.ToString())
            {
                label_Duree_en_mois.Text = hScrollBar_duree.Value.ToString();
            }

            //choix taux
            if (emprunt1.TauxInteretAnnuel == 0.07f)
            {
                radioButton_interet_7.Checked = true;
            }
            else if (emprunt1.TauxInteretAnnuel == 0.08f)
            {
                radioButton_interet_8.Checked = true;
            }
            else if (emprunt1.TauxInteretAnnuel == 0.09f)
            {
                radioButton_interet_9.Checked = true;
            }

            this.label_montant_remb_periodicite.Text = Math.Round(emprunt1.Calcul_Remboursement(), 2).ToString();
            this.label_nb_remboursements.Text = emprunt1.Calcul_Nombre_Mensualite().ToString();
        }
        #endregion
        #region programme
        //saisie le nom et contrôle la saisie du nom
        private void textBox_nom_TextChanged(object sender, EventArgs e)
        {
            if (!Controles.Controle_Saisie_Nom(textBox_nom.Text))
            {
                errorProvider_nom.SetError(textBox_nom, "Saisir uniquement des lettres (30 maximum sauf si c'est nom composés),si c'est un nom composé 15 lettres avant un '-' puis suivi d'un maximum 15 lettres.");
            }
            else
            {
                emprunt1.Nom = textBox_nom.Text;
                errorProvider_nom.SetError(textBox_nom, "");
            }
        }
        // saisie capital emprunté et contrôle la saisie
        private void textBox_capital_emprunte_TextChanged(object sender, EventArgs e)
        {

            if (!Controles.Controle_Saisie_Capital_Emptrunt(textBox_capital_emprunte.Text))
            {
                errorProvider_capital.SetError(textBox_capital_emprunte, "Saisir uniquement des chiffres maximum 10");
            }
            else
            {
                errorProvider_capital.SetError(textBox_capital_emprunte, "");
                emprunt1.CapitalEmprunte = int.Parse(textBox_capital_emprunte.Text);
                MiseAJourIHM();
            }
        }
        // ScrollBar pour determiner le nombre de mois de l'emprunt en fonction de la périodicité
        private void hScrollBar_duree_ValueChanged(object sender, EventArgs e)
        {
            //label_Duree_en_mois.Text = hScrollBar_duree.Value.ToString();
            HScrollBar bar = (HScrollBar)sender;
            if (bar.Value % bar.SmallChange != 0)
            {
                bar.Value = bar.SmallChange * ((bar.Value + bar.SmallChange / 2) / bar.SmallChange);
            }
            emprunt1.DureeEmpruntMois = hScrollBar_duree.Value;
            MiseAJourIHM();
        }
        //choix dans la listbox de la périodicité
        private void listBox_periodicite_rembs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_periodicite_rembs.SelectedIndex == 0)
            {
                emprunt1.PeriodiciteRemboursement = Emprunt.EnumPeriodicite.Mensuel;
            }
            if (listBox_periodicite_rembs.SelectedIndex == 1)
            {
                emprunt1.PeriodiciteRemboursement = Emprunt.EnumPeriodicite.Bimestriel;
            }
            if (listBox_periodicite_rembs.SelectedIndex == 2)
            {
                emprunt1.PeriodiciteRemboursement = Emprunt.EnumPeriodicite.Trimestriel;
            }
            if (listBox_periodicite_rembs.SelectedIndex == 3)
            {
                emprunt1.PeriodiciteRemboursement = Emprunt.EnumPeriodicite.Semestriel;
            }
            if (listBox_periodicite_rembs.SelectedIndex == 4)
            {
                emprunt1.PeriodiciteRemboursement = Emprunt.EnumPeriodicite.Annuelle;
            }
            MiseAJourIHM();
        }
        #region Bouton_Taux
        //boutons de choix du taux annuel
        private void radioButton_interet_7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_interet_7.Checked == true)
            {
                emprunt1.TauxInteretAnnuel = 0.07f;
                MiseAJourIHM();
            }
        }
        private void radioButton_interet_8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_interet_8.Checked == true)
            {
                emprunt1.TauxInteretAnnuel = 0.08f;
                MiseAJourIHM();
            }

        }
        private void radioButton_interet_9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_interet_9.Checked == true)
            {
                emprunt1.TauxInteretAnnuel = 0.09f;
                MiseAJourIHM();
            }

        }
        #endregion

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (textBox_capital_emprunte.Text == "0")
            {
                errorProvider_capitalVide.SetError(textBox_capital_emprunte, "Le Champ Capital doit être supérieur à 0 veuillez saisir un nombre entier de 10 chiffres maximum");
            }
            else
            {
                errorProvider_capitalVide.SetError(textBox_capital_emprunte, "");
            }
        }
        #endregion
    }
}
