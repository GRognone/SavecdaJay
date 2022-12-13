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
        /// Constructeur générique d'un moteur.
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


        /// <summary>
        /// Constructeur par copie d'un moteur
        /// </summary>
        /// <param name="_moteurACopier"></param>

        public void _Moteur(Moteur _moteurACopier)
        {
            this.enMarche = _moteurACopier.enMarche;
        }

        public bool Demarrer()
        {
            if (this.enMarche)
            {
                return false; // veut dire que le moteur est déjà en route donc ne peut pas le faire démarrer
            }
            else
            {
                return true;// veut dire que le moteur n'est pas  en route donc on peut le faire démarrer
            }
            
        }
        public bool EntrainerRoue(Roue roue1, Roue roue2)
        {
            if (this.enMarche) // condition testee en true par defaut peut importe l'initialisation.
            {
                bool rt1 = roue1.Tourner();
                bool rt2 =roue2.Tourner();
                if(rt1 && rt2) // condition testee en true par defaut.
                {
                    return true;
                }
            }
            return false;
        }

    }
}
