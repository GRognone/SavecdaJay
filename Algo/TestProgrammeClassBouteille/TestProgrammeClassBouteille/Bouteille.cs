using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammeClassBouteille
{
    public class Bouteille
    {
        private float contenanceEnCl;
        private float niveauActuelEnCl;
        private bool bouteilleEstOuverte;
        private bool remplirBouteille;
        public Bouteille() // constructeur par defaut.
        {
            contenanceEnCl = 100;
            niveauActuelEnCl = 100;
            bouteilleEstOuverte = false;
            remplirBouteille = false;
        }
        public Bouteille(float contenanceEnCl, float niveauActuelEnCl, bool bouteilleEstOuverte) // constructeur classic
        {
            this.contenanceEnCl = contenanceEnCl;
            this.niveauActuelEnCl = niveauActuelEnCl;
            this.bouteilleEstOuverte = bouteilleEstOuverte;
        }

        public Bouteille(Bouteille _bouteilleACopier) // constructeur par clonage
        {
            contenanceEnCl = _bouteilleACopier.contenanceEnCl;
            niveauActuelEnCl = _bouteilleACopier.niveauActuelEnCl;
            bouteilleEstOuverte = _bouteilleACopier.bouteilleEstOuverte;
        }
        public bool Ouvrir()
        {
            if (bouteilleEstOuverte == true)
            {
                return false;
            }
            else
            {
                bouteilleEstOuverte = true;
                return true;
            }
        }
        public bool Fermer()
        {
            if (bouteilleEstOuverte == false)
            {
                return true;
            }
            else
            {
                bouteilleEstOuverte = false;
                return true;
            }
        }
        public bool Remplir()
        {
            if (contenanceEnCl - niveauActuelEnCl < 100 && contenanceEnCl - niveauActuelEnCl >= 0)
            {
                remplirBouteille = true;
                return true;
            }
            else
            {
                remplirBouteille = false;
                Console.WriteLine("La bouteille est pleine.");
                return false;
            }
            
           
        }
        /*
            public bool Vider(float quantiteAVider)
            {
                Console.WriteLine("Quelle quantité reste-il dans la bouteille svp.");
                contenanceEnCl = float.Parse(Console.ReadLine());
                if (contenanceEnCl > 0 && contenanceEnCl <= 100)
                {
                    quantiteAVider = contenanceEnCl - niveauActuelEnCl;
                    Console.WriteLine($"La quantité à vider est de {quantiteAVider} cl.");
                }
                return true;
            }

            public bool RemplirTout()
            {
                Console.WriteLine("Quelle quantite reste-il dans la bouteille?");
                niveauActuelEnCl = float.Parse(Console.ReadLine());
                if (niveauActuelEnCl >= 0 && niveauActuelEnCl < 100)
                {
                    Console.WriteLine("Remplir toute la bouteille svp.");
                }
                else
                {
                    Console.WriteLine("La bouteille est déja pleine");
                }
                return true;
            }
            public bool ViderTout()
            {
                Console.WriteLine("Quelle quantite reste-il dans la bouteille?");
                niveauActuelEnCl = float.Parse(Console.ReadLine());
                if (niveauActuelEnCl <= 100 && niveauActuelEnCl > 0)
                {
                    Console.WriteLine("Vider toute la bouteille svp.");
                }
                else
                {
                    Console.WriteLine("La bouteille est déja vide");
                }
                return true;
            }*/
    }
}