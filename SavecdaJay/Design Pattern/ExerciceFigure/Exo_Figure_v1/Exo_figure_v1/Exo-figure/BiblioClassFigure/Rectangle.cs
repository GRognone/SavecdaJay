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

        public Rectangle(double largeur, double longueur , double x, double y) : base (x,y)
        {
            this.largeur = largeur;
            this.longueur = longueur;
        }

        public override void SeDessiner()
        {
            Console.WriteLine("Le rectangle a une largeur de " + this.largeur + " et une longueur de " + this.longueur);
        }
    }

}

