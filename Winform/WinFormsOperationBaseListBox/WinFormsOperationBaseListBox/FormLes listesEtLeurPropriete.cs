using ClassLibraryControle;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsOperationBaseListBox
{
    public partial class FormLes_listesEtLeurPropriete : Form
    {
        public FormLes_listesEtLeurPropriete()
        {
            InitializeComponent();
        }

        #region mesBoutons

        private void button_selectionner_Click(object sender, EventArgs e)
        {
            if (Controles.IndexElementAVerifier(textBox_index_element.Text))
            {
                int idSelectionne = int.Parse(textBox_index_element.Text);
                if (idSelectionne < listBox_liste_de_nom.Items.Count)
                {
                    listBox_liste_de_nom.SelectedIndex = idSelectionne;
                    textBox_selected_items.Text = textBox_index_element.Text;
                    textBox_text.Text = listBox_liste_de_nom.Text;
                    textBox_index_element.Clear();
                    errorProvider_index_element.Clear();
                }
                else
                {
                    errorProvider_index_element.SetError(textBox_index_element, "veuillez saisir un numero entre 0 et " + (listBox_liste_de_nom.Items.Count - 1));
                }
            }
            else
            {
                errorProvider_index_element.SetError(textBox_index_element, "veuillez saisir un numero entre 0 et index count -1");
            }
        }

        private void button_ajout_liste_Click(object sender, EventArgs e)
        {
            if (Controles.NomAVerifier(TextBoxSaisieNom.Text))
            {
                if (listBox_liste_de_nom.FindStringExact(TextBoxSaisieNom.Text) == -1) // FindStringExact compare ne nom saisie et les noms dans la liste
                {
                    listBox_liste_de_nom.Items.Add(TextBoxSaisieNom.Text);
                    textBox_items_count.Text = listBox_liste_de_nom.Items.Count.ToString();
                    TextBoxSaisieNom.Clear();
                    TextBoxSaisieNom.Focus();
                    errorProvider_nouvel_element.Clear();
                }
                else
                {
                    errorProvider_nouvel_element.SetError(TextBoxSaisieNom, "Le nom existe déjà dans la liste");
                }
            }
        }

        private void button_vider_liste_Click(object sender, EventArgs e)
        {
            listBox_liste_de_nom.Items.Clear();
            textBox_items_count.Text = listBox_liste_de_nom.Items.Count.ToString();
            textBox_text.Clear();
            textBox_selected_items.Clear(); 
        }

        #endregion

        #region mesTextBoxs

        private void listBox_liste_de_nom_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_selected_items.Text = listBox_liste_de_nom.SelectedIndex.ToString();
            textBox_text.Text = listBox_liste_de_nom.Text;
        }

        private void textBox_saisie_liste_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxSaisieNom.Text != "" && !Controles.NomAVerifier(TextBoxSaisieNom.Text))
            {
                errorProvider_nouvel_element.SetError(TextBoxSaisieNom, "Veuillez-saisir uniquement des lettres et 1 '-' pour les prenoms composés");
            }
            else
            {
                errorProvider_nouvel_element.Clear();
            }
        }

        private void textBox_index_element_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox_index_element.Text != "" && !Controles.IndexElementAVerifier(textBox_index_element.Text))
            {
                errorProvider_index_element.SetError(textBox_index_element, "veuillez saisir un numero entre 0 et " + (listBox_liste_de_nom.Items.Count - 1));
            }
            else
            {
                errorProvider_index_element.Clear();
            }
        }

        #endregion
    }
}
