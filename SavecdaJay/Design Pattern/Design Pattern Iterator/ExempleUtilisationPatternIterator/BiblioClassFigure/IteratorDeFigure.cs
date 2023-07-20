using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClassFigure
{
    public class IteratorDeFigure : IEnumerator<Figure>
    {
        Figures figures;
        int iCurrent;

        public IteratorDeFigure(Figures figures)
        {
            this.figures = figures;
            iCurrent = 0;
        }



        public Figure Current => figures[iCurrent];

        object IEnumerator.Current => figures[iCurrent];

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            iCurrent++; // afinir
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
