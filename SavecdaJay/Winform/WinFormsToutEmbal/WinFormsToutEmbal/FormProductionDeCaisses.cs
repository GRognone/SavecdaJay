using ClassCaisse;
using ClassProduction;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static ClassProduction.Production;
using static System.Windows.Forms.DataFormats;

namespace WinFormsToutEmbal
{

    public partial class FormProductionDeCaisses : Form
    {
        Production maProductionA;
        Production maProductionB;
        Production maProductionC;

        public FormProductionDeCaisses()
        {
            maProductionA = new Production("Caisse A", 100, 3600, "A", EnumerationEtatProduction.PasEncoreDemarre, 12.50f, 11.50f);
            maProductionB = new Production("Caisse B", 100, 720, "B", EnumerationEtatProduction.PasEncoreDemarre, 11.50f, 10.50f);
            maProductionC = new Production("Caisse C", 100, 360, "C", EnumerationEtatProduction.PasEncoreDemarre, 10.50f, 9.50f);
            InitializeComponent();
        }
        //Fermeture de l'application
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Exercice1
        public void MiseAJourIHM()
        {
            textBoxNbCaisseProdDemA.Text = maProductionA.DonneLeNombreDeCaisseValide().ToString();
            textBoxTauxDéfautA.Text = maProductionA.DonneLeTauxDefautHoraireActuel().ToString();
            textBoxDefautDepuisDemA.Text = maProductionA.DonneLeTauxDefautGlobal().ToString();

            textBoxNbCaisseProdDemB.Text = maProductionB.DonneLeNombreDeCaisseValide().ToString();
            textBoxTauxDéfautB.Text = maProductionB.DonneLeTauxDefautHoraireActuel().ToString();
            textBoxDefautDepuisDemB.Text = maProductionB.DonneLeTauxDefautGlobal().ToString();

            textBoxNbCaisseProdDemC.Text = maProductionC.DonneLeNombreDeCaisseValide().ToString();
            textBoxTauxDéfautC.Text = maProductionC.DonneLeTauxDefautHoraireActuel().ToString();
            textBoxDefautDepuisDemC.Text = maProductionC.DonneLeTauxDefautGlobal().ToString();
        }
        private void timerProd_Tick(object sender, EventArgs e)
        {
            if (maProductionA.EtatProduction == EnumerationEtatProduction.Encours)
            {
                maProductionA.AjouterUneCaisse();
                maProductionA.DonneLeNombreDeCaisseValide();
              

                for (int j = 0; j < 10000-1; j++)
                {
                    maProductionA.AjouterUneCaisse();
                    progressBarProductionA.PerformStep();
                }
            }
            if (maProductionB.EtatProduction == EnumerationEtatProduction.Encours)
            {
                maProductionB.AjouterUneCaisse();
                maProductionB.DonneLeNombreDeCaisseValide();
            }
            if (maProductionA.EtatProduction == EnumerationEtatProduction.Encours)
            {
                maProductionC.AjouterUneCaisse();
                maProductionC.DonneLeNombreDeCaisseValide();
            }
                MiseAJourIHM();

        }
        private void demarrerA_Click(object sender, EventArgs e)
        {
            maProductionA.Demarrer();
            demarrerA.Enabled = false;
            arreterA.Enabled = true;
            repriseA.Enabled = false;

        }
        private void arreterA_Click(object sender, EventArgs e)
        {
            maProductionA.Arreter();
            arreterA.Enabled = false;
            repriseA.Enabled = true;
            demarrerA.Enabled = false;
        }
        private void repriseA_Click(object sender, EventArgs e)
        {
            maProductionA.Reprendre();
            arreterA.Enabled = false;
            repriseA.Enabled = true;
            demarrerA.Enabled = false;
        }
        private void demarrerB_Click(object sender, EventArgs e)
        {
            maProductionB.Demarrer();
            demarrerB.Enabled = false;
            arreterB.Enabled = true;
            repriseB.Enabled = false;
        }
        private void arreterB_Click(object sender, EventArgs e)
        {
            maProductionB.Arreter();
            arreterB.Enabled = false;
            repriseB.Enabled = true;
            demarrerB.Enabled = false;
        }
        private void reprendreB_Click(object sender, EventArgs e)
        {
            maProductionB.Reprendre();
            arreterB.Enabled = false;
            repriseB.Enabled = true;
            demarrerB.Enabled = false;
        }
        private void demarrerC_Click(object sender, EventArgs e)
        {
            maProductionC.Demarrer();
            demarrerC.Enabled = false;
            arreterC.Enabled = true;
            repriseC.Enabled = false;
        }
        private void arreterC_Click(object sender, EventArgs e)
        {
            maProductionC.Arreter();
            arreterC.Enabled = false;
            repriseC.Enabled = true;
            demarrerC.Enabled = false;
        }
        private void reprendreC_Click(object sender, EventArgs e)
        {
            maProductionC.Reprendre();
            arreterC.Enabled = false;
            repriseC.Enabled = true;
            demarrerC.Enabled = false;
        }
        #endregion
        #region Exercice2
        //public void MiseAJourIHM()
        //{

        //}
        #endregion

        #region Exercice3
        //public void MiseAJourIHM()
        //{

        //}
        //affichage de l'heure dans le toolStripLabel
        private void timerHeureCourante_Tick(object sender, EventArgs e)
        {
            toolStripLabelDateTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void etatProductionA(ProjectTargetFrameworkAttribute sender, EventArgs e)
        {
            toolStripLabelCaisseA.Text = maProductionA.EtatProduction.ToString();
        }
        #endregion

       
}
}
