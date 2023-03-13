using BiblioVirement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesControles2
{
    public partial class ValidationsEffectuees : Form
    {
        private Virement monFormulaire;


        public ValidationsEffectuees()
        {
            InitializeComponent();
        }

        public ValidationsEffectuees(Virement formulaireARecuperer)
        {
            InitializeComponent();
            monFormulaire = formulaireARecuperer;

            this.label_nom_valide.Text = "Nom : " + formulaireARecuperer.Nom;
            this.label_date_valide.Text = "Date : " + formulaireARecuperer.Date;
            this.label_montant_valide.Text = "Montant : " + formulaireARecuperer.Montant;
            this.label_Cp_valide.Text = "Code Postal : " + formulaireARecuperer.Code_postal;

        }

       
        private void button_ok_valide_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
