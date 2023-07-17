using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClassFigure
{
    public class Cercle : Figure
    { 
        private double rayon;
    
        public Cercle(double rayon, double x, double y) : base( x, y) 
        {
            this.rayon = rayon;
        }
        
        public override void SeDessiner()
        {
            Console.WriteLine("le cercle a pour rayon " + this.rayon);
        }
    }
}
