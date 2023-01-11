using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseLibraryCompte
{
    public class Compte
    {
        private string nomProprietaireCompte;
        private int numeroUnique;
        private int montantDecouvertAutorise;
        private int soldeDuCompte;

        public Compte() : this(0,"", 0, 0)
        {
            
        }

        public Compte(int _numero, string _nom, int _solde, int _decouvertAutorise)
        {
            nomProprietaireCompte = _nom;
            numeroUnique = _numero;
            montantDecouvertAutorise = _decouvertAutorise;
            soldeDuCompte = _solde;
        }

        public void CrediterCompte(int _montant)
        {
            soldeDuCompte = soldeDuCompte +_montant;
            
        }

        public bool DebiterCompte(int _montant)
        {
            if(_montant <= soldeDuCompte - montantDecouvertAutorise)
            {
                soldeDuCompte = soldeDuCompte - _montant;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransfererMontantVersAutreCompte(int _montantATransferer, Compte _compteDestinataire)
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
            return "numero: "+numeroUnique+ " nom: "+ nomProprietaireCompte+ " solde: "+soldeDuCompte+ " decouvert Autorise: "+montantDecouvertAutorise;
        }

        public bool Superieur(Compte _autreCompte)
        {
            if (soldeDuCompte.CompareTo(_autreCompte.soldeDuCompte)==1)
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