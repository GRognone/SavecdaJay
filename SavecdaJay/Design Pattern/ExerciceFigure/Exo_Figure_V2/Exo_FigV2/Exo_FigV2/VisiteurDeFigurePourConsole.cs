using BiblioClassFigure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_FigV2
{
    public class VisiteurDeFigurePourConsole : IVisiteursDeFigure
    {
        

        public void Visit(Cercle cercle) 
        {
           
            Console.WriteLine("Je suis un cercle à la position " + cercle.X + " : " + cercle.Y + " j'ai un rayon de " + cercle.Rayon);
        }

        public void Visit(Rectangle rectangle)
        {
            Console.WriteLine("Je suis un rectangle à la position " + rectangle.X + " : " + rectangle.Y + " j'ai une largeur de " + rectangle.Largeur + " et une longueur de " + rectangle.Longueur);
        }

        public void Visit(Figures figures)
        {
            Console.WriteLine("Je suis une figure à la position " + figures.X + " : " + figures.Y);
        }
    }
}
