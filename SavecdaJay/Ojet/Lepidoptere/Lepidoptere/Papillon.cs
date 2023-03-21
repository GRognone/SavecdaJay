using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere
{
    internal class Papillon : StadeEvolution
    {
        public Papillon()
        {
        }
        public override string SeDeplacer()
        {
            return "Le papillon vole!";
        }

        public override StadeEvolution SeMetamorphoser()
        {
            return this; // retourne lui même (l'objet papillon) à la dernière evolution.
        }
    }
}
