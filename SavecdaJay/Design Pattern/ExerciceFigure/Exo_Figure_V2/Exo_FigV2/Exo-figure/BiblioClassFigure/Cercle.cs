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
        public double Rayon { get => rayon; }


        public Cercle(double rayon, double x, double y) : base(x,y)
        {
            this.rayon = rayon;
        }

        public override void Accept(IVisiteursDeFigure visiteur)
        {
            visiteur.Visit(this);
        }
    }
}
