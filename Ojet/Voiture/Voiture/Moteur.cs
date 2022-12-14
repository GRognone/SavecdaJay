using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    public class Moteur
    {
        private bool enMarche = false;
        /// <summary>
        /// Constructeur classic d'un moteur. 
        /// </summary>
        /// <param name="_enMarche"></param>
        public Moteur(bool _enMarche)
        {
            this.enMarche = _enMarche;
        }


        /// <summary>
        /// Constructeur par défaut d'un moteur
        /// </summary>
        public Moteur() // ce constructeur peut s'écrire aussi ainsi : public Moteur(): this(false){}
        {
            this.enMarche = false;
        }
        //public Moteur() : this(false) { }


        /// <summary>
        /// Constructeur par copie d'un moteur
        /// </summary>
        /// <param name="_moteurACopier"></param>

        public Moteur (Moteur _moteurACopier)
        {
            this.enMarche = _moteurACopier.enMarche;
        }
        /// <summary>
        /// Bascule enMarche de false à true. 
        /// Si enMarche est déjà true, la méthode ne fait rien. 
        /// </summary>
        /// <returns>Retourne false si déjà enMarche est déjà true ou 
        /// retourne true si enMarche est initialement false. </returns>
        public bool Demarrer()
        {
            if (this.enMarche)
            {
                return false; // veut dire que le moteur est déjà en route donc ne peut pas le faire démarrer
            }
            else
            {
                this.enMarche = true;
                return true;// veut dire que le moteur n'est pas  en route donc on peut le faire démarrer
            }
            
        }
        public bool EntrainerRoue(Roue roue1, Roue roue2)
        {
            if (this.enMarche) // condition testee en true par defaut peut importe l'initialisation.
            {
                bool retour1 = roue1.Tourner();// retour de l'action tourner
                bool retour2 =roue2.Tourner();// idem mais roue 2.
                if(retour1 && retour2) // condition testee en true par defaut.
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Permet de stopper 
        /// </summary>
        /// <param name="roue1"></param>
        /// <param name="roue2"></param>
        /// <returns></returns>
        public bool ArreterRoues(Roue roue1, Roue roue2)
        {
            bool retour1 = roue1.Stopper(); // retour de l'action arreterRoues
            bool retour2 = roue2.Stopper();
            if (retour1 && retour2)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// permet de passer enMarche de true à false
        /// </summary>
        /// <returns> retourne true si enMarche passe de true à false </returns>
        public bool Eteindre()
        {
            if (this.enMarche)// si le moteur est en marche
            {
                this.enMarche = false; // arrete le moteur 
                return true; // tu dis que tu as reussi à le faire // et on sort de la methode.
            }
            return false; // sinon tu n'as pas pu le faire et on sort de la methode
        }
    }
}
