using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public override void SeDessiner()
        {
            Console.WriteLine("Je suis une figure");
            foreach (var f in sesFigures) 
            {
                f.SeDessiner();
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
