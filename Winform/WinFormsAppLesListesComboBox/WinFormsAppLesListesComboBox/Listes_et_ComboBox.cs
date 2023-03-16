using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryControles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppLesListesComboBox
{
    public partial class Listes_et_ComboBox : Form
    {
        public Listes_et_ComboBox()
        {
            InitializeComponent();
        }
        #region mes boutons

        private void button_1_element_source_to_cible_Click(object sender, EventArgs e)
        {
            if (comboBox_userInput.SelectedItem != null)
            {
                string item = (string)comboBox_userInput.SelectedItem;
                listBox1.Items.Add(item);
                comboBox_userInput.Items.Remove(item);
                button_1_element_source_to_cible.Enabled = false;
                if (comboBox_userInput.Items.Count == 0)
                {
                    button_1_element_source_to_cible.Enabled = false;
                }
            }
        }

        private void button_All_element_source_to_cible_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBox_userInput.Items.Count ; i++)
            {
                listBox1.Items.Add(comboBox_userInput.Items[i]);
               
                if (comboBox_userInput.Items.Count == 0)
                {
                    button_All_element_source_to_cible.Enabled = false;
                }
            }
            comboBox_userInput.Items.Clear();
        }

        private void button_1_element_cible_to_source_Click(object sender, EventArgs e)
        {

            string itemlistBox1 = (string)listBox1.SelectedItem;
            comboBox_userInput.Items.Add(itemlistBox1);
            listBox1.Items.Remove(itemlistBox1);
            if (listBox1.Items.Count == 0)
            {
                listBox1.Text = "";
                button_1_element_cible_to_source.Enabled = false;
            }

        }

        private void button_all_element_cible_to_source_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                comboBox_userInput.Items.Add(listBox1.Items[i]);

                if (listBox1.Items.Count == 0)
                {
                    button_all_element_cible_to_source.Enabled = false;
                }
            }
            listBox1.Items.Clear();
        }

        private void button_cible_selectline_up_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                int valeurIndex = listBox1.SelectedIndex;
                string valeurItemTemp = (string)listBox1.SelectedItem;
                listBox1.Items.RemoveAt(valeurIndex);
                listBox1.Items.Insert(valeurIndex - 1, valeurItemTemp);
                listBox1.SelectedIndex = valeurIndex - 1;
            }
        }

        private void button_cible_selectline_down_Click(object sender, EventArgs e)
        {


            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                int valeurIndex = listBox1.SelectedIndex;
                string valeurTemp = (string)listBox1.SelectedItem;
                listBox1.Items.RemoveAt(valeurIndex);
                listBox1.Items.Insert(valeurIndex + 1, valeurTemp);
                listBox1.SelectedIndex = valeurIndex + 1;
            }
        }

        #endregion

        #region comboBox

        private void comboBox_userInput_TextChanged(object sender, EventArgs e)
        {

            if (comboBox_userInput.Text != "" && !Controles.SaisieAVerifier(comboBox_userInput.Text))
            {
                errorProvider_control_user_input.SetError(comboBox_userInput, "Veuillez saisir des lettres et pour un nom composé utilisez le trait d'union");
            }
            else
            {
                errorProvider_control_user_input.SetError(comboBox_userInput, "");
            }
            if (comboBox_userInput.Items.Count == 0)
            {
                comboBox_userInput.Text = "";
                button_1_element_source_to_cible.Enabled = false;
                button_All_element_source_to_cible.Enabled = false;
            }
        }
        private void comboBox_userInput_DropDown(object sender, EventArgs e)
        {
            if (Controles.SaisieAVerifier(comboBox_userInput.Text))
            {
                if (comboBox_userInput.FindStringExact(comboBox_userInput.Text) == -1
                    && listBox1.FindStringExact(comboBox_userInput.Text) == -1)
                {
                    comboBox_userInput.Items.Add(comboBox_userInput.Text);
                    this.button_All_element_source_to_cible.Enabled = true;

                    comboBox_userInput.ResetText();

                }
            }
        }
        #endregion
        #region Activation Boutons

        private void comboBox_userInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.button_1_element_source_to_cible.Enabled = true;
        }

        private void listBox1_Selected_IndexChanged(object sender, EventArgs e)
        {
            this.button_1_element_cible_to_source.Enabled = true;
            this.button_all_element_cible_to_source.Enabled = true;
            this.button_cible_selectline_up.Enabled = true;
            this.button_cible_selectline_down.Enabled = true;


            if (listBox1.Items.Count == 0)
            {
                comboBox_userInput.Text = "";
                this.button_1_element_cible_to_source.Enabled = false;
                this.button_all_element_cible_to_source.Enabled = false;
                this.button_cible_selectline_up.Enabled = false;
                this.button_cible_selectline_down.Enabled = false;
            }

            // desactive le bouton up sur la 1ere ligne de la liste
            if (listBox1.SelectedIndex == 0)
            {
                this.button_cible_selectline_up.Enabled = false;
            }

            // desactive le bouton up sur la dernière ligne de la liste
            if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
            {
                this.button_cible_selectline_down.Enabled = false;
            }

        }

        #endregion

    }
}
