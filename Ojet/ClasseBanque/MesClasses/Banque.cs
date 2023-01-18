using System.Collections;

namespace ClasseBanque
{
    public class Banque
    {
        private Compte[] mesComptes = new Compte[3];
        private int nbComptes;
        private string nom;
        private string ville;

        /// <summary>
        /// Constructeur classic
        /// </summary>
        /// <param name="mesComptes"></param>
        /// <param name="nbComptes"></param>
        /// <param name="_nom"></param>
        /// <param name="_ville"></param>
        public Banque (string _nom, string _ville)
        {
            this.nom = _nom;
            this.ville = _ville;
            nbComptes = mesComptes.Length;
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
        public Banque (Banque _banque) : this(_banque.nom, _banque.ville)
        {

        }
        public override string ToString()
        {
            
        }
        private void AjouteCompte(Compte unCompte)
        {
            throw new System.NotImplementedException();
        }
        public void AjouteCompte(int num, string _nom, int _solde, int _decouvertAutorise)

        {
            throw new System.NotImplementedException();
        }
        
    }
}