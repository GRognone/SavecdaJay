using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    public class Roue
    {
        private string dimensionPneu;
        private bool tourne;

        /// <summary>
        /// Constructeur générique d'une roue
        /// </summary>
        /// <param name="_dimensionPneu"></param>
        /// <param name="_tourne"></param>
        public  Roue(string _dimensionPneu, bool _tourne)
        {
            this.dimensionPneu = _dimensionPneu;
            this.tourne = _tourne;
        }

        /// <summary>
        /// Constructeur par défaut d'une roue
        /// </summary>
        public Roue()
        {
            this.tourne=false;
            this.dimensionPneu = "205/55/14";
        }

        /// <summary>
        /// Constructeur par copie d'une roue
        /// </summary>
        /// <param name="_roueACopier"></param>
        public Roue(Roue _roueACopier)
        {
            this.tourne = _roueACopier.tourne;
            this.dimensionPneu = _roueACopier.dimensionPneu;  
        }
        public bool Tourner()
        {
            if (this.tourne)
            {
                return false;
            }
            else
            {
                this.tourne = true;
                return true;
            }
        }
    }
}
