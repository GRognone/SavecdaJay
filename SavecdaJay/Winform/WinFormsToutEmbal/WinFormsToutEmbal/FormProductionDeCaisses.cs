using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsToutEmbal
{

    public partial class FormProductionDeCaisses : Form
    {

        public FormProductionDeCaisses()
        {
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            private void DernierEtat(Form f)
            {
                f.Load += new EventHandler(IndicationDuDernierEvenement);
                f.Show();// la montre dans le Mdi
                f.FormClosed += new FormClosedEventHandler(ChangerLabelALaFermetureDuneFenetre);
            }
            private void ChangerLabelAuClicDeChangementEtat(object? sender, FormClosedEventArgs e) // objet? veut dire que l'objet est nullable.
            {
                toolStripLabelCaisseA.Text = "Fermeture de " + ((Form)sender).Text;
            }
            private void IndicationDuDernierEvenement(object? sender, EventArgs e)
            {
                toolStripLabelCaisseA.Text = "Ouverture de " + ((Form)sender).Text;
            }
            toolStripLabelDateTime.Text = DateTime.Now.ToString("HH:mm:ss");
            #endregion
        }
}
