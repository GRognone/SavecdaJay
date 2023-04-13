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
        int tickCaisse;

        public FormProductionDeCaisses()
        {
            InitializeComponent();
            maProductionA = new Production("Caisse A", 100, 3600, "A", EnumerationEtatProduction.PasEncoreDemarre, 12.50f, 11.50f);
            maProductionB = new Production("Caisse B", 100, 720, "B", EnumerationEtatProduction.PasEncoreDemarre, 11.50f, 10.50f);
            maProductionC = new Production("Caisse C", 300, 360, "C", EnumerationEtatProduction.PasEncoreDemarre, 10.50f, 9.50f);
            tickCaisse = 0; //initialise un compteur de rotation du tick pour faire avancer le progresBar.
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
            textBoxTauxDéfautA.Text = maProductionA.DonneLeTauxDefautHeure().ToString();
            textBoxDefautDepuisDemA.Text = maProductionA.DonneLeTauxDefautDepuisDemarrage().ToString();
            toolStripDemarrerA.Enabled = buttonDemarrerA.Enabled = maProductionA.EtatProduction == EnumerationEtatProduction.PasEncoreDemarre;
            toolStripRepriseA.Enabled = buttonRelancerA.Enabled = maProductionA.EtatProduction == EnumerationEtatProduction.EnPause;
            toolStripArreterA.Enabled = buttonSuspenduA.Enabled = maProductionA.EtatProduction == EnumerationEtatProduction.Encours;
            toolStripLabelCaisseA.Text = "Caisse A: " + maProductionA.EtatProduction.ToString();// affichage etat production A dans le toolstrip pour exercice 1

            textBoxNbCaisseProdDemB.Text = maProductionB.DonneLeNombreDeCaisseValide().ToString();
            textBoxTauxDéfautB.Text = maProductionB.DonneLeTauxDefautHeure().ToString();
            textBoxDefautDepuisDemB.Text = maProductionB.DonneLeTauxDefautDepuisDemarrage().ToString();
            toolStripDemarrerB.Enabled = buttonDemarrerB.Enabled = maProductionB.EtatProduction == EnumerationEtatProduction.PasEncoreDemarre;
            toolStripRepriseB.Enabled = buttonRelancerB.Enabled = maProductionB.EtatProduction == EnumerationEtatProduction.EnPause;
            toolStripArreterB.Enabled = buttonSuspenduB.Enabled = maProductionB.EtatProduction == EnumerationEtatProduction.Encours;
            toolStripLabelCaisseB.Text = "Caisse B: " + maProductionB.EtatProduction.ToString();// affichage etat production B dans le toolstrip pour exercice 1

            textBoxNbCaisseProdDemC.Text = maProductionC.DonneLeNombreDeCaisseValide().ToString();
            textBoxTauxDéfautC.Text = maProductionC.DonneLeTauxDefautHeure().ToString();
            textBoxDefautDepuisDemC.Text = maProductionC.DonneLeTauxDefautDepuisDemarrage().ToString();
            toolStripDemarrerC.Enabled = buttonDemarrerC.Enabled = maProductionC.EtatProduction == EnumerationEtatProduction.PasEncoreDemarre;
            toolStripRepriseC.Enabled = buttonRelancerC.Enabled = maProductionC.EtatProduction == EnumerationEtatProduction.EnPause;
            toolStripArreterC.Enabled = buttonSuspenduC.Enabled = maProductionC.EtatProduction == EnumerationEtatProduction.Encours;
            toolStripLabelCaisseC.Text = "Caisse C: " + maProductionC.EtatProduction.ToString();// affichage etat production C dans le toolstrip pour exercice 1
        }
        //affichage de l'heure dans le toolStripLabel
        private void timerHeureCourante_Tick(object sender, EventArgs e)
        {
            toolStripLabelDateTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void timerProd_Tick(object sender, EventArgs e)
        {
            tickCaisse++;
            if (maProductionA.EtatProduction == EnumerationEtatProduction.Encours && tickCaisse % 10 == 0)
            {
                maProductionA.AjouterUneCaisse();
                maProductionA.DonneLeNombreDeCaisseValide();
                maProductionA.DonneLeTauxDefautHeure();
                maProductionA.DonneLeTauxDefautDepuisDemarrage();
                progressBarProductionA.Value = (int)((maProductionA.DonneLeNombreDeCaisseValide() / (double)(maProductionA.NbCaisseAProduire)) * progressBarProductionA.Maximum);
            }
            if (maProductionB.EtatProduction == EnumerationEtatProduction.Encours && tickCaisse % 2 == 0)
            {
                maProductionB.AjouterUneCaisse();
                maProductionB.DonneLeNombreDeCaisseValide();
                maProductionB.DonneLeTauxDefautHeure();
                maProductionB.DonneLeTauxDefautDepuisDemarrage();
                progressBarProductionB.Value = (int)((maProductionB.DonneLeNombreDeCaisseValide() / (double)(maProductionB.NbCaisseAProduire)) * progressBarProductionB.Maximum);
            }
            if (maProductionC.EtatProduction == EnumerationEtatProduction.Encours)
            {
                maProductionC.AjouterUneCaisse();
                maProductionC.DonneLeNombreDeCaisseValide();
                maProductionC.DonneLeTauxDefautHeure();
                maProductionC.DonneLeTauxDefautDepuisDemarrage();
                progressBarProductionC.Value = (int)((maProductionC.DonneLeNombreDeCaisseValide() / (double)(maProductionC.NbCaisseAProduire)) * progressBarProductionC.Maximum);
            }
            MiseAJourIHM();
        }
        #region lancement Production
        private void demarrerA_Click(object sender, EventArgs e)
        {
            maProductionA.Demarrer();
        }
        private void arreterA_Click(object sender, EventArgs e)
        {
            maProductionA.Arreter();
        }
        private void repriseA_Click(object sender, EventArgs e)
        {
            maProductionA.Reprendre();
        }
        private void demarrerB_Click(object sender, EventArgs e)
        {
            maProductionB.Demarrer();
        }
        private void arreterB_Click(object sender, EventArgs e)
        {
            maProductionB.Arreter();
        }
        private void reprendreB_Click(object sender, EventArgs e)
        {
            maProductionB.Reprendre();
        }
        private void demarrerC_Click(object sender, EventArgs e)
        {
            maProductionC.Demarrer();
        }
        private void arreterC_Click(object sender, EventArgs e)
        {
            maProductionC.Arreter();
        }
        private void reprendreC_Click(object sender, EventArgs e)
        {
            maProductionC.Reprendre();
        }
        #endregion
        #endregion
    }
}
