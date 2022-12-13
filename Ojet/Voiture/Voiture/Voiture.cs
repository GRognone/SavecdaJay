using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Voiture
{
    public class Voiture
    {
        string marque = "Audi";
        private Moteur sonMoteur;
        private Roue[] ses4Roues;

        public Voiture()
        {
            this.marque = "Peugeot";
            this.sonMoteur = new Moteur();
            this.ses4Roues = new Roue[4] {new Roue(), new Roue(), new Roue(), new Roue()};
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Demarrer()
        {
            return sonMoteur.Demarrer();
        }
        public bool Avancer()
        {
            return sonMoteur.EntrainerRoue(ses4Roues[0], ses4Roues[1]);
        }
        public bool Arreter()
        {
            return true;
        }

        
    }      
}


