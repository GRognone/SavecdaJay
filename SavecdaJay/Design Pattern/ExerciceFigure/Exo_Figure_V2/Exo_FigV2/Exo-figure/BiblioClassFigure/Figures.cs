using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClassFigure
{
    public class Figures : Figure
    {
        List<Figure> sesFigures;

        public Figures(double x, double y) : base(x, y)
        {
            sesFigures = new List<Figure>();
        }

        public override void Accept(IVisiteursDeFigure visiteur)
        {
            Console.WriteLine("Je suis une figure");
            // visit à coder à la place du writeLine
            foreach (var f in sesFigures)
            {
                f.Accept(visiteur);
            }
        }

        public void Remove(Figure figure)
        {
            sesFigures.Remove(figure);
        }

        public void Add(Figure figure) 
        {
            sesFigures.Add(figure);

        }

    }
}
