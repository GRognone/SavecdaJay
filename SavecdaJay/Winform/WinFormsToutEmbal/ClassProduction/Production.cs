using ClassCaisse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;
using static ClassProduction.Production;

namespace ClassProduction
{
    public class Production
    {
        Random caisseInvalide;

        string nom;
        int nbCaisseAProduire;
        int tpsNecessairePourProduireUneCaisseEnMs;
        string typeDeCaisse;
        float hauteurCaisse;
        float largeurCaisse;
        List<Caisse> sesCaissesProduites; // instantiation d'une liste de caisse issue de la classe Caisse.

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
            caisseInvalide = new Random();
        }
        private void ChangeEtat(EnumerationEtatProduction nouvelEtat)
        {
            this.etatProduction = nouvelEtat;
        }
        public int DonneLeNombreDeCaisseValide()
        {
            int nbCaissesValide = 0;
            for (int i = 0; i < sesCaissesProduites.Count; i++)
            {
                if (sesCaissesProduites[i].Valide)
                {
                    nbCaissesValide++;
                }
            }
            return nbCaissesValide;
        }
        public bool CreationCaisseDeffectueuse()
        {
            int v = caisseInvalide.Next(0, 100);
            bool valide = false;
            if (v != 10 && v != 100)
            {
                valide = true;
            }
            return valide;
        }
        public void AjouterUneCaisse()
        {
            bool valide = CreationCaisseDeffectueuse();
            Caisse caisse = new Caisse(DateTime.Today, typeDeCaisse, hauteurCaisse, largeurCaisse, valide);
            sesCaissesProduites.Add(caisse);
            if (DonneLeNombreDeCaisseValide() == nbCaisseAProduire)
            {
                etatProduction = EnumerationEtatProduction.Termine;
            }
        }
        public double DonneLeTauxDefautHeure()
        {
            int nbCaisseNonValideDerniereHeure = 0;
            int nbCaisseFabriqueesDerniereHeure= 0;

            for (int i = 0; i < sesCaissesProduites.Count; i++)
            {
                TimeSpan interval = DateTime.Now - sesCaissesProduites[i].Date; // determine l'ecart de temps entre le depart et l'instant present.
                if (interval.Milliseconds < 3600000)
                {
                    nbCaisseFabriqueesDerniereHeure++;

                    if (!sesCaissesProduites[i].Valide)
                    {
                        nbCaisseNonValideDerniereHeure++;
                    }
                }
            }
            if (nbCaisseFabriqueesDerniereHeure == 0)
            {
                return 0;
            }
            else
            {
                double tauxHoraire = (double) nbCaisseNonValideDerniereHeure / (double) nbCaisseFabriqueesDerniereHeure;
                tauxHoraire = Math.Round(tauxHoraire, 4);// pour arrondir à 4 chiffre après la décimale
                return tauxHoraire;
            }
            
        }
        public double DonneLeTauxDefautDepuisDemarrage()
        {
            double caisseValide = DonneLeNombreDeCaisseValide();
            double tauxDefGlobal = (sesCaissesProduites.Count - caisseValide) / sesCaissesProduites.Count;
            tauxDefGlobal = Math.Round(tauxDefGlobal, 4); // pour arrondir à 4 chiffre après la décimale
            return tauxDefGlobal;
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
