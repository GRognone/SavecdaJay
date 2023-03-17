using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
                button_1_element_source_to_cible.Enabled = true;
            }
            ActivationSendSourceToCible();
        }
        private void button_all_element_source_to_cible_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBox_userInput.Items.Count; i++)
            {
                listBox1.Items.Add(comboBox_userInput.Items[i]);
            }
            comboBox_userInput.Items.Clear();
            comboBox_userInput.Text = "";
            ActivationAllSendSourceToCible();

        }
        private void button_1_element_cible_to_source_Click(object sender, EventArgs e)
        {

            string itemlistBox1 = (string)listBox1.SelectedItem;
            comboBox_userInput.Items.Add(itemlistBox1);
            listBox1.Items.Remove(itemlistBox1);
            button_1_element_cible_to_source.Enabled = true;
            if (listBox1.Items.Count == 0)
            {
                listBox1.Text = "";
                button_1_element_cible_to_source.Enabled = false;
            }
            ActivationSendCibleToSource();
            ActivationUpDown();
        }
        private void button_all_element_cible_to_source_Click(object sender, EventArgs e)
        {
            //autre solution pour transferer l'ensemble d'ine liste à l'autre.
            object[] items = new object[listBox1.Items.Count];
            listBox1.Items.CopyTo(items, 0);
            listBox1.Items.Clear();
            comboBox_userInput.Items.AddRange(items);
            //button_all_element_cible_to_source.Enabled = false;*/
            ActivationSendCibleToSource();
            ActivationUpDown();
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
            ActivationUpDown();
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
            ActivationUpDown();
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
        }
        private void comboBox_userInput_DropDown(object sender, EventArgs e)
        {
            if (comboBox_userInput.Text != "" && !Controles.SaisieAVerifier(comboBox_userInput.Text))
            {
                errorProvider_control_user_input.SetError(comboBox_userInput, "Veuillez saisir des lettres et pour un nom composé utilisez le trait d'union");
            }
            else
            {
                errorProvider_control_user_input.SetError(comboBox_userInput, "");
            }
            if (Controles.SaisieAVerifier(comboBox_userInput.Text))
            {
                if (comboBox_userInput.FindStringExact(comboBox_userInput.Text) == -1
                    && listBox1.FindStringExact(comboBox_userInput.Text) == -1)
                {
                    comboBox_userInput.Items.Add(comboBox_userInput.Text);

                    // ActivationSendSourceToCible();

                    comboBox_userInput.ResetText();

                }
                ActivationAllSendSourceToCible();
            }
        }
        #endregion

        #region Activation Boutons

        private void comboBox_userInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivationSendSourceToCible();

        }
        private void listBox1_Selected_IndexChanged(object sender, EventArgs e)
        {
            ActivationSendCibleToSource();
            ActivationUpDown();

        }
        private void ActivationSendSourceToCible()
        {
            if (comboBox_userInput.SelectedItem == null)
            {
                this.button_1_element_source_to_cible.Enabled = false;
            }
            else
            {
                this.button_1_element_source_to_cible.Enabled = true;
            }
        }
        private void ActivationAllSendSourceToCible()
        {
            if (comboBox_userInput.Items.Count > 0)
                this.button_all_element_source_to_cible.Enabled = true;
            else
                this.button_all_element_source_to_cible.Enabled = false;
        }
        private void ActivationSendCibleToSource()
        {
            if (listBox1.Items.Count == 0)
            {
                this.button_1_element_cible_to_source.Enabled = false;
                this.button_all_element_cible_to_source.Enabled = false;
            }
            else
            {
                this.button_1_element_cible_to_source.Enabled = true;
                this.button_all_element_cible_to_source.Enabled = true;
            }
        }
        private void ActivationUpDown()
        {
            // active le bouton up sur la 1ere ligne de la liste
            this.button_cible_selectline_up.Enabled = listBox1.SelectedIndex > 0;
            // desactive le bouton up sur la dernière ligne de la liste
            this.button_cible_selectline_down.Enabled = listBox1.SelectedIndex < listBox1.Items.Count - 1 &&
                listBox1.SelectedIndex != -1;
        }

        #endregion
    }
}
