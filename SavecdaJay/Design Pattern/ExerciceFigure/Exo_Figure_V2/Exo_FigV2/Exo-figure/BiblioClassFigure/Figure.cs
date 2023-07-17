using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClassFigure
{
    public abstract class Figure
    {
        protected double x;
        protected double y;

        public double X { get; }
        public double Y { get; }

        public Figure(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract void Accept(IVisiteursDeFigure visiteur);
    }
}
