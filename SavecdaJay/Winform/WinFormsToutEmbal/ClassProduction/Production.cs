using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;
using static ClassProduction.Production;

namespace ClassProduction
{
    public class Production
    {
        string nom;
        int nbCaisseAProduire;
        int tpsNecessairePourProduireUneCaisseEnMs;
        string typeDeCaisse;

        public string Nom { get => nom; set => nom = value; }
        public int NbCaisseAProduire { get => nbCaisseAProduire; set => nbCaisseAProduire = value; }
        public int TpsNecessairePourProduireUneCaisseEnMs { get => tpsNecessairePourProduireUneCaisseEnMs; set => tpsNecessairePourProduireUneCaisseEnMs = value; }
        public string TypeDeCaisse { get => typeDeCaisse; set => typeDeCaisse = value; }

        public event DelegateProduction ProductionEnCours;
        public event DelegateProduction ProductionMiseEnPause;
        public event DelegateProduction ProductionTermine;

        public enum EnumerationEtatProduction : ushort
        {
            PasEncoreDemarre = 1,
            Encours = 2,
            EnPause = 3,
            Termine = 4,
        }
        EnumerationEtatProduction etatProduction;
        public EnumerationEtatProduction EtatProduction { get => etatProduction; set => etatProduction = value; }

        /// <summary>
        /// Constructeur Classic
        /// </summary>
        /// <param name="_date"></param>
        /// <param name="_nom"></param>
        /// <param name="_hauteur"></param>
        /// <param name="_largeur"></param>
        /// <param name="_valide"></param> 
        public Production(string _nom, int _nbCaisseAProduire, int _tpsNecessairePourProduireUneCaisseEnMs, string _typeDeCaisse, EnumerationEtatProduction _etatProduction)
        {
            nom = _nom;
            nbCaisseAProduire = _nbCaisseAProduire;
            tpsNecessairePourProduireUneCaisseEnMs = _tpsNecessairePourProduireUneCaisseEnMs;
            typeDeCaisse = _typeDeCaisse;
            etatProduction = _etatProduction;
        }

        private void ChangeEtat(EnumerationEtatProduction nouvelEtat)
        {
            this.etatProduction = nouvelEtat;
        }
        public int DonneLeNombreDeCaisseValide(int _nbCaisseValide)
        {
            int nbCaisseValide =  ;
        }
        public void AjouterUneCaisse()
        {

        }
        public float DonneLeTauxGlobal(float _tauxGlobal)
        {

        }
        public float DonneLeTauxDefautHoraireActuel( float _tauxDefautHoraireActuel)
        {

        }
        public bool Demarrer()
        {
            if (etatProduction != EnumerationEtatProduction.PasEncoreDemarre)
            {
                etatProduction = EnumerationEtatProduction.Encours;
                return true;
            }
            return false;
        }
        public bool MettreEnPause()
        {
            if (etatProduction != EnumerationEtatProduction.Encours)
            {
                etatProduction = EnumerationEtatProduction.EnPause;
                return true;
            }
            return false;
        }
        public bool ReprendreProduction()
        {
            if (etatProduction != EnumerationEtatProduction.EnPause)
            {
                etatProduction = EnumerationEtatProduction.Encours;
                return true;
            }
            return false;
        }
        public delegate void DelegateProduction(Production sender);
        public delegate void DelegateNouvelleCaisseProduite(Production sender, bool nbDeCaisseActuelles);
        public delegate void DelegateEtatProductionChange(Production sender, EnumerationEtatProduction nouvelEtat);

    }

}