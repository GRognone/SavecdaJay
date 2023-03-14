using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private void button_ajout_liste_Click(object sender, EventArgs e)
        {
            if (listBox_liste_de_nom.FindStringExact(textBox_saisie_liste.Text) == -1) // FindStringExact compare ne nom saisie et les noms dans la liste
            {
                listBox_liste_de_nom.Items.Add(textBox_saisie_liste.Text);
                textBox_items_count.Text = listBox_liste_de_nom.Items.Count.ToString();
                textBox_saisie_liste.Clear();
                textBox_saisie_liste.Focus();
            }
            else
            {
                errorProvider_nouvel_element.SetError(textBox_saisie_liste, "Le nom existe déjà dans la liste");
            }
        }
        private void button_selectionner_Click(object sender, EventArgs e)
        {
            if (listBox_liste_de_nom.Items.Count >= 1)
            {
                listBox_liste_de_nom.SelectedIndex = int.Parse(textBox_index_element.Text);
                textBox_selected_items.Text = textBox_index_element.Text;
                textBox_text.Text = listBox_liste_de_nom.Text;
            }
        }
        private void button_vider_liste_Click(object sender, EventArgs e)
        {
            listBox_liste_de_nom.Items.Clear();
            textBox_items_count.Text = listBox_liste_de_nom.Items.Count.ToString();
        }
        private void listBox_liste_de_nom_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_selected_items.Text = listBox_liste_de_nom.SelectedIndex.ToString();
            textBox_text.Text = listBox_liste_de_nom.Text;
            textBox_index_element.Clear();
        }
        private void textBox_saisie_liste_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox_index_element_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
