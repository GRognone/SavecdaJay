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
        private float quantiteARemplir;
        private float quantiteAVider;

        /// <summary>
        /// constructeur par defaut.
        /// </summary>
        public Bouteille()
        {
            contenanceEnCl = 100;
            niveauActuelEnCl = 100;
            bouteilleEstOuverte = false;

        }

        /// <summary>
        /// // constructeur classic
        /// </summary>
        /// <param name="contenanceEnCl"></param>
        /// <param name="niveauActuelEnCl"></param>
        /// <param name="bouteilleEstOuverte"></param>
        public Bouteille(float contenanceEnCl, float niveauActuelEnCl, bool bouteilleEstOuverte)
        {
            this.contenanceEnCl = contenanceEnCl;
            this.niveauActuelEnCl = niveauActuelEnCl;
            this.bouteilleEstOuverte = bouteilleEstOuverte;
        }

        /// <summary>
        /// constructeur par clonage
        /// </summary>
        /// <param name="_bouteilleACopier"></param>
        public Bouteille(Bouteille _bouteilleACopier)
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
                return false;
            }
            else
            {
                bouteilleEstOuverte = false;
                return true;
            }
        }

        /// <summary>
        /// sert à voir la quantite qu'il reste pour la vider ! dans cet exemple la quantité à vider est connue !!!
        /// </summary>
        /// <param name="quantiteAVider"></param>
        /// <returns></returns>
        public bool Vider(float quantiteAVider)
        {
            if (bouteilleEstOuverte && contenanceEnCl >= quantiteAVider && quantiteAVider > 0)
            {
                niveauActuelEnCl = niveauActuelEnCl - quantiteAVider; // niveauActuelEnCl -= quantiteAVider ( 2 eme facon d'ecrire cette ligne)
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// vider tout, vide completement le niveau actuel
        /// </summary>
        /// <returns></returns>
        public bool Vider()
        {
            {
                return Vider(niveauActuelEnCl);
            }

        }

        /// <summary>
        /// rempli la bouteille de la quantité souhaité 
        /// </summary>
        /// <returns></returns>
        public bool Remplir(float quantiteARemplir)
        {
            if (bouteilleEstOuverte && quantiteARemplir > 0 && quantiteARemplir <= contenanceEnCl - niveauActuelEnCl)
            {
                niveauActuelEnCl = niveauActuelEnCl + quantiteARemplir;
                return true;
            }
            return false;
        }

        /// <summary>
        ///  complete le niveau actuelle jusqu'au niveau max
        /// </summary>
        /// <returns></returns>
        public bool Remplir()
        {
            {
                return Remplir(this.contenanceEnCl - niveauActuelEnCl);
            }
        }
    }
}

