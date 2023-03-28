using BiblioFormulaireSaisie;
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
    public partial class ValidationEffectuee : Form
    {
        private TransactionBoursiere monForm;

        public ValidationEffectuee()
        {
            InitializeComponent();
        }

        public ValidationEffectuee(TransactionBoursiere formulaireARecuperer)
        {
            InitializeComponent();
            monForm = formulaireARecuperer;
            lblData.Text = monForm.ToString();
        }

        private void button1_ok_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(" Fin de l'application", "FIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            Application.Exit();
        }
    }
}
