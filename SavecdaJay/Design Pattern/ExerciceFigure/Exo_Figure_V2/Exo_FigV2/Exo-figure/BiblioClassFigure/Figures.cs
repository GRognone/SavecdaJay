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

        private double xFigures;
        private double yFigures;

        public double XFigures { get => xFigures; }
        public double YFigures { get => yFigures; }
        public Figures(double x, double y) : base(x, y)
        {
            sesFigures = new List<Figure>();
            this.xFigures = x;
            this.yFigures = y;
        }

        public override void Accept(IVisiteursDeFigure visiteur)
        {

            visiteur.Visit(this);
            foreach (var f in sesFigures)
            {
                f.X = f.X + xFigures;
                f.Y = f.Y + yFigures;
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
