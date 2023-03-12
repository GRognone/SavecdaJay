using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioAdditionneur
{
    public class Addition
    {
        private List<int> numbers;

        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        public Addition()
        {
            this.numbers = new List<int>();
        }

        public Addition(int n)
        {
            this.numbers = new List<int>() { n };
        }

        /// <summary>
        ///  programmation du calcul de la classe
        /// </summary>
        /// <param name="n"></param>
        public void AjouterUnNombre(int n)
        {
            this.numbers.Add(n); // ligne qui dit d'additionner tous les boutons clicqués
        }

        public int RecupererResultat()
        {
            int somme = 0;
            for (int i = 0; i < this.numbers.Count(); i++)
            {
                somme += numbers[i];
            }
        return somme;
        }
    }
}