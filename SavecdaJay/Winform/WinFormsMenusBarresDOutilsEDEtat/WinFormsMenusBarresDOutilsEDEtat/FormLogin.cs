using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMenusBarresDOutilsEDEtat
{
    public partial class FormLogin : Form
    {
        private const string login = "Roberto";
        private const string password = "123456";
        public FormLogin()
        {
            InitializeComponent();
            // cache les caractères du mot de passe par un asterisk.
            textBoxPassword.PasswordChar = '*';
            // determine le nombre de caractères pour le mot de passe characters.
            textBoxPassword.MaxLength = 10;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == login && textBoxPassword.Text == password)
            {

            }
            else
            {
                errorProviderSaisieIncorrecte.SetError(textBoxPassword,"verifier identifiant et mot de passe");
            }


        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
