using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClassFigure
{
    public  interface IVisiteursDeFigure
    {
        public abstract void Visit(Cercle cercle);

        public abstract void Visit(Rectangle rectangle);

        public abstract void Visit(Figures figure);
    }
}
