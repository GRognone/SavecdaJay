using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere
{
    internal class Chrysalide : StadeEvolution
    {
        public Chrysalide()
        {
        }
        public override string SeDeplacer()
        {
            return "La Chrysalide ne se déplace pas;";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return new Papillon();
        }
    }
}
