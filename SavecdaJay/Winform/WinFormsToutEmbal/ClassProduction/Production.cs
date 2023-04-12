using ClassCaisse;
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
        List<Caisse> sesCaissesProduites; // instantiation d'une liste de caisse issue de la classe Caisse.

        float hauteurCaisse;
        float largeurCaisse;

        public string Nom { get => nom; set => nom = value; }
        public int NbCaisseAProduire { get => nbCaisseAProduire; set => nbCaisseAProduire = value; }
        public int TpsNecessairePourProduireUneCaisseEnMs { get => tpsNecessairePourProduireUneCaisseEnMs; set => tpsNecessairePourProduireUneCaisseEnMs = value; }
        public string TypeDeCaisse { get => typeDeCaisse; set => typeDeCaisse = value; }
        public float HauteurCaisse { get => hauteurCaisse; private set => hauteurCaisse = value; }
        public float LargeurCaisse { get => largeurCaisse; private set => largeurCaisse = value; }

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
        public EnumerationEtatProduction EtatProduction { get => etatProduction; private set => etatProduction = value; }

        /// <summary>
        /// Constructeur Classic
        /// </summary>
        /// <param name="_date"></param>
        /// <param name="_nom"></param>
        /// <param name="_hauteur"></param>
        /// <param name="_largeur"></param>
        /// <param name="_valide"></param> 
        public Production(string _nom, int _nbCaisseAProduire, int _tpsNecessairePourProduireUneCaisseEnMs, string _typeDeCaisse, EnumerationEtatProduction _etatProduction, float _hauteurCaisse, float _largeurCaisse)
        {
            nom = _nom;
            nbCaisseAProduire = _nbCaisseAProduire;
            tpsNecessairePourProduireUneCaisseEnMs = _tpsNecessairePourProduireUneCaisseEnMs;
            typeDeCaisse = _typeDeCaisse;
            etatProduction = _etatProduction;
            sesCaissesProduites = new List<Caisse>();
            hauteurCaisse = _hauteurCaisse;
            largeurCaisse = _largeurCaisse;
        }

        private void ChangeEtat(EnumerationEtatProduction nouvelEtat)
        {
            this.etatProduction = nouvelEtat;
        }
        public int DonneLeNombreDeCaisseValide()
        {
            for (int i = 0; i < sesCaissesProduites.Count; i++)
            {

            }  
            return sesCaissesProduites.Count;
        }
        public void AjouterUneCaisse()
        {
            Caisse caisse = new Caisse(DateTime.Today, typeDeCaisse, hauteurCaisse, largeurCaisse, true);
            sesCaissesProduites.Add(caisse);
            if (sesCaissesProduites.Count == nbCaisseAProduire)
            {
                etatProduction = EnumerationEtatProduction.Termine;
            }
        }
        public float DonneLeTauxDefautGlobal()
        {
    
            return 0;
        }
        public float DonneLeTauxDefautHoraireActuel()
        {
            Random tauxDefautHoraire = new Random();
            for (int i = 0; i < 10; i++)
            {
                tauxDefautHoraire.Next(10);
            }
            return 0;
        }
        public bool Demarrer()
        {
            if (etatProduction == EnumerationEtatProduction.PasEncoreDemarre)
            {
                etatProduction = EnumerationEtatProduction.Encours;
                return true;
            }
            return false;
        }
        public bool Arreter()
        {
            if (etatProduction == EnumerationEtatProduction.Encours)
            {
                etatProduction = EnumerationEtatProduction.EnPause;
                return true;
            }
            return false;
        }
        public bool Reprendre()
        {
            if (etatProduction == EnumerationEtatProduction.EnPause)
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