using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Calculs
{
    public class Soustraction : Binaire
    {
        public Soustraction (Expression ex1, Expression ex2) : base(ex1 , ex2){}

        public override double Calculer()
        {
            double somme =  ex1.Calculer() - ex2.Calculer();
            return somme;
        }

        public override string ToString()
        {
            return Calculer().ToString();
        }
    }
}
