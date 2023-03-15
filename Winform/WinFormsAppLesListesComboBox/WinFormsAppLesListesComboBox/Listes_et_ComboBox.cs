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
            listBox1.Items.Add(comboBox_userInput.Text);
            comboBox_userInput.Items.Remove(comboBox_userInput.Items[comboBox_userInput.SelectedIndex]);
            if (comboBox_userInput.Items.Count == 0)
                comboBox_userInput.Text = "";

        }

        private void buttonbutton_All_element_source_to_cible_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < listBox1.Items.Count; i++)
            {
                comboBox_userInput.Items.Add(listBox1.Items[i]);
                if (comboBox_userInput.Items.Count == 0)
                    comboBox_userInput.Text = "";
            }

            
            


        }

        private void button_1_element_cible_to_source_Click(object sender, EventArgs e)
        {
            comboBox_userInput.Items.Add(listBox1.Text);
            listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
            if (listBox1.Items.Count == 0)
                listBox1.Text = "";
        }

        private void button_all_element_cible_to_source_Click(object sender, EventArgs e)
        {

        }

        private void button_cible_selectline_up_Click(object sender, EventArgs e)
        {

        }

        private void button_cible_selectline_down_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region comboBox

        private void comboBox_userInput_TextChanged(object sender, EventArgs e)
        {
            if (!Controles.SaisieAVerifier(comboBox_userInput.Text))
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
            if (Controles.SaisieAVerifier(comboBox_userInput.Text))
            {
                if (comboBox_userInput.FindStringExact(comboBox_userInput.Text) == -1
                    && listBox1.FindStringExact(listBox1.Text) == -1)
                {
                    comboBox_userInput.Items.Add(comboBox_userInput.Text);
                    comboBox_userInput.ResetText();
                    comboBox_userInput.Focus();
                }
            }
        }
        #endregion

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
