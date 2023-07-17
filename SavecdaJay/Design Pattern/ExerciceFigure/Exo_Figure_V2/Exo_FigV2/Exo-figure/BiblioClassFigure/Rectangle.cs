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

        public Rectangle ( double largeur, double longueur, double x, double y) : base(x, y)
        {
            this.largeur = largeur;
            this.longueur = longueur;
        }

        public override void Accept(IVisiteursDeFigure visiteur)
        {
            Console.WriteLine("Le rectangle à une largeur de " + largeur + " et une longueur de " + longueur);
            // visit à coder à la place du writeLine
        }
    }
}
