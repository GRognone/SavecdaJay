﻿using System;
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

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Figure(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract void Accept(IVisiteursDeFigure visiteur);


    }
}
