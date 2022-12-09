using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere
{
    public abstract class StadeEvolution
    {
        public abstract string SeDeplacer();
        public abstract StadeEvolution SeMetamorphoser();
        public StadeEvolution()
        {

        }
    }
}

