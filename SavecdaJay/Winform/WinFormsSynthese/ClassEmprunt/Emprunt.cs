using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmprunt
{
    public class Emprunt
    {
       
        string nom;
        public string Nom { get => nom;/*set => nom = Value;*/ }

        int capitalEmprunte;
        public int CapitalEmprunte { get => capitalEmprunte;/*set => capital_emprunte = Value;*/ }

        int dureeEmpruntMois;
        public int DureeEmpruntMois { get => dureeEmpruntMois;/*set => dureeEpruntMois = Value;*/ }

        public enum EnumPeriodicite : ushort 
        {
            Mensuel = 1,
            Bimestriel = 2,
            Trimestriel = 3,
            Semestriel = 6,
            Annuelle = 12,
        }
        EnumPeriodicite periodiciteRemboursement;
        public EnumPeriodicite PeriodiciteRemboursement { get => periodiciteRemboursement;/*set => periodiciteRemboursement = value;*/}

        float tauxInteretAnnuel;
        public float TauxInteretAnnuel { get => tauxInteretAnnuel;/*set => tauxInteret = Value;*/}

        /// <summary>
        /// Contructeur classic
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="nom"></param>
        /// <param name="dureeEmpruntMois"></param>
        /// <param name="periodiciteRemboursement"></param>
        /// <param name="tauxInteret"></param>
        public Emprunt(string _nom, int _capitalEmprunte, int _dureeEmpruntMois, EnumPeriodicite _periodiciteRemboursement, float _tauxInteretAnnuel)
        {
            nom = _nom;
            capitalEmprunte = _capitalEmprunte;
            dureeEmpruntMois = _dureeEmpruntMois;
            periodiciteRemboursement = _periodiciteRemboursement;
            tauxInteretAnnuel = _tauxInteretAnnuel;
        }

        public override string ToString()
        {
            return "Emprunt" + nom + " " + capitalEmprunte + " " + dureeEmpruntMois + " " + periodiciteRemboursement + " " + tauxInteretAnnuel + " ";
        }

        // calcul mensualité emprunt mensuel
        public double Calcul_Remboursement_Mensuel(double _rbsMens)
        {
            if (periodiciteRemboursement == EnumPeriodicite.Mensuel)
            { 
                double nrbs = (double) Calcul_Nombre_Mensualite();
                double rbsMens = capitalEmprunte * (tauxInteretAnnuel / (1 - (1 + tauxInteretAnnuel)*Math.Pow(-nrbs ,1)));
            }
            return _rbsMens;
        }
        // calcul mensualité emprunt Bimestriel
        public double Calcul_Remboursement_Bimestiel(double _rbsMens)
        {
            if (periodiciteRemboursement == EnumPeriodicite.Bimestriel)
            {
                double nrbs = (double)Calcul_Nombre_Mensualite();
                double rbsMens = capitalEmprunte * (tauxInteretAnnuel / (1 - (1 + tauxInteretAnnuel) * Math.Pow(-nrbs, 1)));
            }
            return _rbsMens;
        }



        // Calcul du nombre de remboursement en fonction de la duree du credit et de la periodicité des remboursements
        public int Calcul_Nombre_Mensualite()
        {
            int nbMensualite = dureeEmpruntMois / (int) periodiciteRemboursement;
            return nbMensualite;
        }
    }
}
