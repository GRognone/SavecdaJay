using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClassFigure
{
    public  interface IVisiteursDeFigure
    {
        public  void Visit(Cercle cercle);

        public  void Visit(Rectangle rectangle);

        public  void Visit(Figures figures);
    }
}
