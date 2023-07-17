using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClassFigure
{
    public class Cercle : Figure
    {
        private double rayon;
        public double Rayon { get; set; }


        public Cercle(double rayon, double x, double y) : base(x,y)
        {
            this.rayon = rayon;
        }

        public override void Accept(IVisiteursDeFigure visiteur)
        {

            Console.WriteLine("Le cercle a pour rayon " + this.rayon);
            // visit à coder à la place du writeLine
        }
    }
}
