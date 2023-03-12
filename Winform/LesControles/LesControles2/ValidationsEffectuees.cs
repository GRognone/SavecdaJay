using BibliOFormulaireBanque;
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
        private FormulaireBanque monFormulaire;
     

        public ValidationsEffectuees()
        {
            InitializeComponent();
        }

        public ValidationsEffectuees(FormulaireBanque FormulaireARecuperer)
        {
            InitializeComponent();
            monFormulaire = FormulaireARecuperer;
            
        }
    }
}
