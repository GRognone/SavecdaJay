using System.Collections;
using System.Text.RegularExpressions;

namespace ClasseBanque
{
    public class Banque
    {
        private List<Compte> mesComptes;
        private string nom;
        private string ville;

        /// <summary>
        /// Constructeur classic
        /// </summary>
        /// <param name="mesComptes"></param>
        /// <param name="_nom"></param>
        /// <param name="_ville"></param>
        public Banque(string _nom, string _ville) : this (_nom, _ville, new())
        {
        }
        
        public Banque(string _nom, string _ville, List<Compte> _comptes)
        {
            this.nom = _nom;
            this.ville = _ville;
            if (_comptes.Count() > 0)
            {
                mesComptes = new();
                foreach (Compte c in _comptes)
                {
                    mesComptes.Add(new Compte(c));
                }
            } else
            {
                mesComptes = _comptes;
            }

        }
        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        public Banque() : this("Credit Mutuel", "Nice")
        {

        }
        /// <summary>
        /// Contructeur par clonage
        /// </summary>
        /// <param name="_banque"></param>
        public Banque(Banque _banque) : this(_banque.nom, _banque.ville)
        {

        }
        public override string ToString()
        {
            return String.Format("Info relative à ma banque, nom : {0}, ville : {1}, nbClients: {3}",
                nom,ville,mesComptes.Count());
        }
        private void AjouteCompte(Compte unCompte)
        {
            if (RendCompte(unCompte.NumeroUnique) == null)
                mesComptes.Add(unCompte);
        }
        public void AjouteCompte(int _num, string _nom, int _solde, int _decouvertAutorise)
        {
            AjouteCompte(new Compte(_num, _nom, _solde, _decouvertAutorise));
        }
        public Compte CompteSup()
        {
            int idCompteLePlusRiche = 0;
            if (mesComptes.Count() > 1)
            {
                for (int i = 1; i < mesComptes.Count(); i++)
                {
                    if (mesComptes[i].Superieur(mesComptes[idCompteLePlusRiche]))
                    {
                        idCompteLePlusRiche = i;
                    }
                }
            }
            return mesComptes[idCompteLePlusRiche];
        }
        public Compte? RendCompte(int _numCompte) // ? signifie est nullable
        {
            Compte? rt = null;
            int i = 0;
            while(i < mesComptes.Count() && rt == null)
            {
                if (mesComptes[i].NumeroUnique == _numCompte)
                {
                    rt = mesComptes[i];
                }
                i++;
            }
            return rt;
        }
        public bool Transferer(int numExpediteur, int numDestinataire, float montant)

    }
}