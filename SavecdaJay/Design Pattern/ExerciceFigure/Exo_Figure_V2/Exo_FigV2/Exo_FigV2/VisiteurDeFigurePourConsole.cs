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

        public override void Visit(Cercle cercle) 
        {
            Console.WriteLine("Je suis un cercle à la position " + cercle.X + ":" + cercle.Y + " j'ai un rayon de " + cercle.Rayon);
        }
    }
}
