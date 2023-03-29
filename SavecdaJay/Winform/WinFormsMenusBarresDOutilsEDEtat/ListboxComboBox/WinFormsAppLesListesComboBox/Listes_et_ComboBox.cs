using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
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
            // entree données fixe combobox
            comboBox_userInput.Items.AddRange(new string[] { "a", "b", "c", "d" });
        }

        #region mes boutons

        private void button_1_element_source_to_cible_Click(object sender, EventArgs e)
        {
            string item = (string)comboBox_userInput.SelectedItem;
            int indexComboBox = (int)comboBox_userInput.SelectedIndex;
            listBox1.Items.Add(item);
            comboBox_userInput.Items.Remove(item);
            button_1_element_source_to_cible.Enabled = true;
            ActivationSendSourceToCible();
            if (comboBox_userInput.Items.Count == 0)
            {
                button_all_element_source_to_cible.Enabled = false;
            }
            button_all_element_cible_to_source.Enabled = true;
            // selection element liste combobox en commencant par les élements suivants l'index selectionné
            // si celui-ci est le dernier il selectionnera le precedent.
            if (comboBox_userInput.Items.Count >= 1)
            {
                if (indexComboBox >= comboBox_userInput.Items.Count)
                {
                    this.comboBox_userInput.SelectedIndex = indexComboBox - 1;
                }
                else
                {
                    this.comboBox_userInput.SelectedIndex = indexComboBox;
                }
            }
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
            ActivationAllSendAllCibleToSource();
            //ActivationSendSourceToCible();
            //ActivationSendCibleToSource();

        }
        private void button_1_element_cible_to_source_Click(object sender, EventArgs e)
        {
            string itemlistBox1 = (string)listBox1.SelectedItem;
            int index = (int)listBox1.SelectedIndex;
            comboBox_userInput.Items.Add(itemlistBox1);
            listBox1.Items.Remove(itemlistBox1);
            button_1_element_cible_to_source.Enabled = true;
            ActivationSendCibleToSource();
            ActivationUpDown();
            if (listBox1.Items.Count == 0)
            {
                button_all_element_cible_to_source.Enabled = false;
            }
            button_all_element_source_to_cible.Enabled = true;

            // selection element liste combobox en commencant par les élements suivants l'index selectionné
            // si celui-ci est le dernier il selectionnera le precedent.
            if (listBox1.Items.Count >= 1)
            {
                if (index >= listBox1.Items.Count)
                {
                    this.listBox1.SelectedIndex = index - 1;
                }
                else
                {
                    this.listBox1.SelectedIndex = index;
                }
            }
        }
        private void button_all_element_cible_to_source_Click(object sender, EventArgs e)
        {
            ////autre solution pour transferer l'ensemble d'une liste à l'autre.
            //object[] items = new object[listBox1.Items.Count];
            //listBox1.Items.CopyTo(items, 0);
            //listBox1.Items.Clear();
            //comboBox_userInput.Items.AddRange(items);
            //button_all_element_cible_to_source.Enabled = false;
            //ActivationUpDown();
            //ActivationAllSendSourceToCible();
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    comboBox_userInput.Items.Add(listBox1.Items[i]);
                }
                listBox1.Items.Clear();
                listBox1.Text = "";
                ActivationAllSendAllCibleToSource();
                ActivationAllSendSourceToCible();
                //ActivationSendCibleToSource();
                //ActivationSendSourceToCible();

            }
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
            if (listBox1.SelectedItem == null)
            {
                this.button_1_element_cible_to_source.Enabled = false;
            }
            else
            {
                this.button_1_element_cible_to_source.Enabled = true;
            }
        }
        private void ActivationAllSendAllCibleToSource()
        {
            if (listBox1.Items.Count > 0)
            {
                this.button_all_element_cible_to_source.Enabled = true;
            }
            else
            {
                this.button_all_element_cible_to_source.Enabled = false;
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
