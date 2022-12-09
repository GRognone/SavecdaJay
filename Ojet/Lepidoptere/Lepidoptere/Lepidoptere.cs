using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere
{
    public class Lepidoptere
    {
        private StadeEvolution stadeCourant;

        public Lepidoptere()
        {
            stadeCourant = new Oeuf();
        }

        public void SeMetamorphoser()
        {
            stadeCourant.SeMetamorphoser();
        }
    }
}
