using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsLesDifferentsObjetsGraphiques
{
    public partial class FormLesDifferentsObjetsGraphiques : Form
    {
        public FormLesDifferentsObjetsGraphiques()
        {
            InitializeComponent();
        }
        public FormLesDifferentsObjetsGraphiques(string texte)
        {
            InitializeComponent();
            InitializeComponent2(texte);
        }
        private void InitializeComponent2(string texte) 
        {
            textBox_texte_saisi.Text = texte;
        }
        private void textBox_texte_saisi_TextChanged(object sender, EventArgs e)
        {
            //this.groupBox_choix.Enabled = textBox_texte_saisi.Text != "" autre facon d'ecrire
            if (textBox_texte_saisi.Text == "")
            {
                //si on efface le texte le groupe se ferme
                this.groupBox_choix.Enabled = false;
                this.checkBox_couleur_fond.Checked = false;
                this.checkBox_couleur_caractere.Checked = false;
                this.checkBox_casse.Checked = false;
            }
            else
            {
                this.groupBox_choix.Enabled = true;
            }

            if (radioButton_casse_minuscule.Checked == true)
            {
                this.label_rendu_test.Text = textBox_texte_saisi.Text.ToLower();
            }
            else if (radioButton_casse_majuscule.Checked == true)
            {
                this.label_rendu_test.Text = textBox_texte_saisi.Text.ToUpper();
            }
            else
            {
                label_rendu_test.Text = textBox_texte_saisi.Text;
            }
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
                this.radioButton_fond_vert.Checked = false;
                this.radioButton_fond_bleu.Checked = false;
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
        }
        private void radioButton_fond_bleu_CheckedChanged(object sender, EventArgs e)
        {
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
                this.radioButton_caractere_blanc.Checked = false;
                this.radioButton_caractere_noir.Checked = false;
            }
        }
        private void radioButton_caractere_rouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_caractere_rouge.Checked == true)
            {
                this.label_rendu_test.ForeColor = Color.Red;
            }
            else
            {
                this.label_rendu_test.ForeColor = Color.Empty;
            }
        }
        private void radioButton_caractere_blanc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_caractere_blanc.Checked == true)
            {
                this.label_rendu_test.ForeColor = Color.White;
            }
            else
            {
                this.label_rendu_test.ForeColor = Color.Empty;
            }
        }
        private void radioButton_caractere_noir_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_caractere_noir.Checked == true)
            {
                this.label_rendu_test.ForeColor = Color.Black;
            }
            else
            {
                this.label_rendu_test.ForeColor = Color.Empty;
            }
        }
        // donne acces aux boutons de changement majuscule minuscule
        private void checkBox_casse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_casse.Checked == true)
            {
                this.groupBox_casse.Visible = true;

            }
            else if (checkBox_casse.Checked == false)
            {
                this.groupBox_casse.Visible = false;
                this.radioButton_casse_minuscule.Checked = false;
                this.radioButton_casse_majuscule.Checked = false;
            }
        }
        // transforme les caracteres en minuscule
        private void radioButton_casse_minuscule_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_casse_minuscule.Checked == true)
            {
                this.label_rendu_test.Text = textBox_texte_saisi.Text.ToLower();
            }
            else
            {
                this.label_rendu_test.Text = textBox_texte_saisi.Text;
            }
        }
        // transforme les caracteres en majuscule
        private void radioButton_casse_majuscule_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_casse_majuscule.Checked == true)
            {
                this.label_rendu_test.Text = textBox_texte_saisi.Text.ToUpper();
            }
            else
            {
                this.label_rendu_test.Text = textBox_texte_saisi.Text;
            }
        }
    }
}

