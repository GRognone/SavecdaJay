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

            visiteur.Visit(this);
            foreach (var f in sesFigures)
            {
                f.X = f.X + this.x;
                f.Y = f.Y + this.y;
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
