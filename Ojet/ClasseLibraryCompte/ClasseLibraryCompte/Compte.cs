using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseLibraryCompte
{
    public class Compte
    {
        public string nomProprietaireCompte;
        public int numeroUnique;
        public int montantDecouvertAutorise;
        public float soldeDuCompte;

        public Compte() : this(0,"", 0f, 0)
        {
            
        }

        public Compte(int _numero, string _nom, float _solde, int _decouvertAutorise)
        {
            nomProprietaireCompte = _nom;
            numeroUnique = _numero;
            montantDecouvertAutorise = _decouvertAutorise;
            soldeDuCompte = _solde;
        }

        public void CrediterCompte(float _montant)
        {
            soldeDuCompte = soldeDuCompte +_montant;
            
        }

        public bool DebiterCompte(float _motant)
        {
            if(soldeDuCompte <= montantDecouvertAutorise)
            {
                return false;
            }
            return true;
        }

        public bool TransfererMontantVersAutreCompte(float _montantATransferer, Compte _compteDestinataire)
        {
            return false;
        }

        public string ToString()
        {
            return "numero: "+numeroUnique+ " nom: "+ nomProprietaireCompte+ " solde: "+soldeDuCompte+ " decouvert Autorise: "+montantDecouvertAutorise;
        }

        public bool Superieur(Compte _autreCompte)
        {
            return false;
        }

        public void ChangerDecouver(int nouveauDecouvert)
        {
            montantDecouvertAutorise = nouveauDecouvert;
        }
    }
}

