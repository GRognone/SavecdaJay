using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAdditionneur
{
    public class Addition
    {
        private List<int> numbers;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Addition()
        {
            this.numbers = new List<int>(); // equivalent à  --> this.numbers = new()
        }

        public Addition(int n)
        {
            this.numbers = new List<int>() { n };
        }
        public void AjouterNombre(int n)
        {
            this.numbers.Add(n); // ajoute à l'addition ce nombre issu du clic
        }

        public int RecupererResultat()
        {
            int somme = 0;
            for (int i = 0; i < numbers.Count(); i++)
            {
                somme += numbers[i];
            }
            return somme;
        }
    }
}
