using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClassFigure
{
    public class Rectangle : Figure
    {
        private double largeur;
        private double longueur;

        public double Largeur { get => largeur;}
        public double Longueur { get => longueur;}
        public Rectangle ( double largeur, double longueur, double x, double y) : base(x, y)
        {
            this.largeur = largeur;
            this.longueur = longueur;
        }

        public override void Accept(IVisiteursDeFigure visiteur)
        {
            visiteur.Visit(this);
        }
    }
}
