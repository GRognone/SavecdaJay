using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TestProgrammeClassBouteille.ExceptionsBouteilles;

namespace TestProgrammeClassBouteille
{
    public class Bouteille
    {
        private float contenanceEnCl;
        private float niveauActuelEnCl;
        private bool bouteilleEstOuverte;


        #region Exception

        //Exception si la valeur du contenant est <=0
        public float ContenanceEnCl
        {
            get => contenanceEnCl;
            set
            {
                if (value < 0)
                {
                    throw new ValeurDeContenuImpossibleException();
                }
                else
                {
                    contenanceEnCl = value;
                }
            }

        }

        //Exception si le niveau actuel est <=0
        public float NiveauActuelEnCl
        {
            get => niveauActuelEnCl;
            set
            {
                if (value <= 0)
                {
                    throw new ValeurDeContenuImpossibleException();
                }
                else
                {
                    niveauActuelEnCl = value;
                }
            }
        }

        public bool BouteilleEstOuverte { get { return bouteilleEstOuverte; } private set { bouteilleEstOuverte = value; } }
        
        #endregion


        /// <summary>
        /// constructeur par defaut.
        /// </summary>
        public Bouteille()
        {
            ContenanceEnCl = 100;
            NiveauActuelEnCl = 100;
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
            this.ContenanceEnCl = contenanceEnCl;
            if (contenanceEnCl <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(contenanceEnCl), "La contenance en cl doit être supérieur ou égale à 0");
            }

            this.NiveauActuelEnCl = niveauActuelEnCl;
            this.bouteilleEstOuverte = bouteilleEstOuverte;
        }

        /// <summary>
        /// constructeur par clonage
        /// </summary>
        /// <param name="_bouteilleACopier"></param>
        public Bouteille(Bouteille _bouteilleACopier)
        {
            ContenanceEnCl = _bouteilleACopier.ContenanceEnCl;
            NiveauActuelEnCl = _bouteilleACopier.NiveauActuelEnCl;
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
            if (quantiteAVider <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if
            (bouteilleEstOuverte && ContenanceEnCl >= quantiteAVider && quantiteAVider > 0)
            {
                NiveauActuelEnCl = NiveauActuelEnCl - quantiteAVider; // niveauActuelEnCl -= quantiteAVider ( 2 eme facon d'ecrire cette ligne)
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
                return Vider(NiveauActuelEnCl);
            }

        }

        /// <summary>
        /// rempli la bouteille de la quantité souhaité 
        /// </summary>
        /// <returns></returns>
        public bool Remplir(float quantiteARemplir)
        {
            if (quantiteARemplir > ContenanceEnCl) 
            {
                throw new ArgumentOutOfRangeException();
            }

            if (bouteilleEstOuverte && quantiteARemplir > 0 && quantiteARemplir <= ContenanceEnCl - NiveauActuelEnCl)
            {
                NiveauActuelEnCl = NiveauActuelEnCl + quantiteARemplir;
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
                return Remplir(this.ContenanceEnCl - NiveauActuelEnCl);
            }
        }
    }
}

