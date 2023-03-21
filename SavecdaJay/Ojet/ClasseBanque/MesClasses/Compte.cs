namespace ClasseBanque
{
    public class Compte
    {
        private string nomProprietaireCompte;
        private int numeroUnique;
        private int montantDecouvertAutorise;
        private float soldeDuCompte;

        public string NomProprietaireCompte { get => nomProprietaireCompte;  }
        public int NumeroUnique { get => numeroUnique;  }
        public int MontantDecouvertAutorise { get => montantDecouvertAutorise;  }
        public float SoldeDuCompte { get => soldeDuCompte;  }

        public Compte() : this(0, "", 0, 0)
        {

        }
        /// <summary>
        /// constructeur classic
        /// </summary>
        /// <param name="_numero"></param>
        /// <param name="_nom"></param>
        /// <param name="_solde"></param>
        /// <param name="_decouvertAutorise"></param>
        public Compte(int _numero, string _nom, float _solde, int _decouvertAutorise)
        {
            nomProprietaireCompte = _nom;
            numeroUnique = _numero;
            montantDecouvertAutorise = _decouvertAutorise;
            soldeDuCompte = _solde;
        }
        /// <summary>
        /// constructeur par clonage
        /// </summary>
        /// <param name="aCopier"></param>
        public Compte(Compte aCopier) : this(aCopier.numeroUnique, aCopier.nomProprietaireCompte, aCopier.soldeDuCompte, aCopier.montantDecouvertAutorise)
        {

        }

        public void CrediterCompte(float _montant)
        {
            soldeDuCompte = soldeDuCompte + _montant;

        }

        public bool DebiterCompte(float _montant)
        {
            if (_montant <= soldeDuCompte - montantDecouvertAutorise)
            {
                soldeDuCompte = soldeDuCompte - _montant;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransfererMontantVersAutreCompte(float _montantATransferer, Compte _compteDestinataire)
        {
            if (this.DebiterCompte(_montantATransferer))
            {
                _compteDestinataire.CrediterCompte(_montantATransferer);
                return true;

            }
            else
            {
                return false;
            }
        }



        public override string ToString()
        {
            return "numero: " + numeroUnique + " nom: " + nomProprietaireCompte + " solde: " + soldeDuCompte + " decouvert Autorise: " + montantDecouvertAutorise;
        }

        public bool Superieur(Compte _autreCompte)
        {
            if (soldeDuCompte.CompareTo(_autreCompte.soldeDuCompte) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}