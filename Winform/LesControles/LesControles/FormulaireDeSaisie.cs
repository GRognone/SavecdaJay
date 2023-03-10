using BiblioFormulaireSaisie;
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

namespace LesControles
{
    public partial class FormulaireDeSaisie : Form
    {

        private TransactionBoursiere monform;

        public FormulaireDeSaisie()
        {
            InitializeComponent();
            monform = new("","");

        }

        private void button1_valider_Click(object sender, EventArgs e)
        {
            textBox1_nom.Text = textBox1_nom.Text + "";
            textBox2_date.Text = textBox2_date.Text + "";
            textBox3_montant.Text = textBox3_montant.Text + "";
            textBox4_code_postal.Text = textBox4_code_postal.Text + "";
            
            
                MessageBox.Show(textBox1_nom.Text+"\r\n"+textBox2_date.Text+"\r\n"+textBox3_montant.Text+"\r\n"+textBox4_code_postal.Text,"Validation effectuée",
                    MessageBoxButtons.OK);
            
                


        }

        private void button2_effacer_Click(object sender, EventArgs e)
        {
            textBox1_nom.Clear();
            errorProvider1_nom.SetError(textBox1_nom, "");
            textBox2_date.Clear();
            errorProvider_date.SetError(textBox2_date, "");
            textBox3_montant.Clear();
            errorProvider_montant.SetError(textBox3_montant, "");
            textBox4_code_postal.Clear();
            errorProvider_date.SetError(textBox4_code_postal, "");
        }

        private void textBox1_nom_TextChanged(object sender, EventArgs e)
        {
            if (!Controles.Controle_saisie_nom(textBox1_nom.Text)) // si la saisie est incorrecte 
            {
                errorProvider1_nom.SetError(textBox1_nom, "Saisir uniquement des lettres maximum 30 lettres");
            } else
            {
                errorProvider1_nom.SetError(textBox1_nom, "");
            }
        }

        private void textBox2_date_TextChanged(object sender, EventArgs e)
        {
            if (!Controles.Controle_saisie_date(textBox2_date.Text))
            {
                errorProvider_date.SetError(textBox2_date, "Saisir une date correcte ");
            }
            else
            {
                errorProvider_date.SetError(textBox2_date, "");
            }
        }

        private void textBox3_montant_TextChanged(object sender, EventArgs e)
        {
            if (!Controles.Controle_Saisie_Montant(textBox3_montant.Text))
            {
                errorProvider_montant.SetError(textBox3_montant, "Saisir un montant en chiffre suivi ou pas d'une decimale à 2 chiffres");
            }
            else
            {
                errorProvider_montant.SetError(textBox3_montant, "");
            }
        }

        private void textBox4_code_postal_TextChanged(object sender, EventArgs e)
        {
            if (!Controles.Controle_Saisie_Code_Postal(textBox4_code_postal.Text))
            {
                errorProvider_date.SetError(textBox4_code_postal, "Saisir un code postal correcte à 5 chiffres");
            }
            else
            {
                errorProvider_date.SetError(textBox4_code_postal, "");
            }
        }
    }
}
