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
        public string Nom { get => nom; set => nom = value; }

        int capitalEmprunte;
        public int CapitalEmprunte { get => capitalEmprunte; set => capitalEmprunte = value; }

        int dureeEmpruntMois;
        public int DureeEmpruntMois { get => dureeEmpruntMois; set => dureeEmpruntMois = value; }

        public enum EnumPeriodicite : ushort
        {
            Mensuel = 1,
            Bimestriel = 2,
            Trimestriel = 3,
            Semestriel = 6,
            Annuelle = 12,
        }
        EnumPeriodicite periodiciteRemboursement;
        public EnumPeriodicite PeriodiciteRemboursement { get => periodiciteRemboursement; set => periodiciteRemboursement = value;}

        float tauxInteretAnnuel;
        public float TauxInteretAnnuel { get => tauxInteretAnnuel; set => tauxInteretAnnuel = value;}

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
 
        // calcul mensualité emprunt
        public double Calcul_Remboursement()
        {
            double remboursement = (double)capitalEmprunte * (Calcul_taux_Annuel_Periodicite() / (1- Math.Pow((1+ Calcul_taux_Annuel_Periodicite()),-Calcul_Nombre_Mensualite())));
            return remboursement; 
        }
        // Calcul du taux Annuel
        public double Calcul_taux_Annuel_Periodicite()
        {
            double tauxAnnuelPeriodicite = tauxInteretAnnuel * (int)periodiciteRemboursement / 12;
            return tauxAnnuelPeriodicite;
        }
        // Calcul du nombre de remboursement en fonction de la duree du credit et de la periodicité des remboursements
        public int Calcul_Nombre_Mensualite()
        {
            int nbMensualite = dureeEmpruntMois / (int)periodiciteRemboursement;
            return nbMensualite;
        }
    }
}
