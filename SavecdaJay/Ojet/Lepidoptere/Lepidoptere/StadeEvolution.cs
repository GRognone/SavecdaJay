﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere
{
   abstract class StadeEvolution
    {
        public StadeEvolution()
        {

        }
        public abstract string SeDeplacer();
        
        public abstract StadeEvolution SeMetamorphoser();
    }
}

