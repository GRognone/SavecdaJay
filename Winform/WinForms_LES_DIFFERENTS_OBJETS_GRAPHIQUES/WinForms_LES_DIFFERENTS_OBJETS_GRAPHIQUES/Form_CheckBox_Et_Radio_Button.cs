using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_LES_DIFFERENTS_OBJETS_GRAPHIQUES
{
    public partial class Form_CheckBox_Et_Radio_Button : Form
    {
        public Form_CheckBox_Et_Radio_Button()
        {
            InitializeComponent();
        }

        private void textBox_texte_saisi_TextChanged(object sender, EventArgs e)
        {
            if (textBox_texte_saisi.Text == "")
            {
                this.groupBox_choix.Enabled = false;
            }
            else
            {
                this.groupBox_choix.Enabled = true;
            }

            label_rendu_test.Text = textBox_texte_saisi.Text;
        }

        private void checkBox_couleur_fond_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_couleur_fond.Checked == true)
            {
                this.groupBox_fond.Visible = true;
            }
            else
            {
                this.groupBox_fond.Visible = false;
                this.radioButton_fond_rouge.Checked = false;
                this.radioButton_caractere_vert.Checked = false;
                this.radioButton_caractere_bleu.Checked = false;
            }

        }

        private void radioButton_fond_rouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_fond_rouge.Checked == true)
            {
                this.label_rendu_test.BackColor = Color.Red;
            }
            else
            {
                this.label_rendu_test.BackColor = Color.Empty;
            }
        }

        private void radioButton_fond_vert_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_fond_vert.Checked == true)
            {
                this.label_rendu_test.BackColor = Color.Green;
            }
            else
            {
                this.label_rendu_test.BackColor = Color.Empty;
            }
        }

        private void radioButton_fond_bleu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_fond_bleu.Checked == true)
            {
                this.label_rendu_test.BackColor = Color.Blue;
            }
            else
            {
                this.label_rendu_test.BackColor = Color.Empty;
            }
        }

        private void checkBox_couleur_caractere_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_couleur_caractere.Checked == true)
            {
                this.groupBox_caractere.Visible = true;
            }
            else
            {
                this.groupBox_caractere.Visible = false;
                this.radioButton_caractere_rouge.Checked = false;
                this.radioButton_caractere_vert.Checked = false;
                this.radioButton_caractere_bleu.Checked = false;

            }
        }

        private void checkBox_casse_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton_caractere_rouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_caractere_rouge.Checked == true)
            {
                this.label_rendu_test.BackColor = Color.Red;
            }
            else
            {
                this.label_rendu_test.BackColor = Color.Empty;
            }
        }

        private void radioButton_caractere_vert_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_caractere_bleu_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
