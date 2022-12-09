using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere
{
    internal class Oeuf : StadeEvolution
    {
        public override string SeDeplacer()
        {
            return "L'oeuf ne se déplace pas";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Chenille();
        }
        public Oeuf()
        {

        }
    }
}
