using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere
{
    internal class Chenille : StadeEvolution
    {
        public override string SeDeplacer()
        {
            return "La chenille rampe";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Chrysalide();
        }
        public Chenille()
        {

        }
    }
}
