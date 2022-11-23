using TrouverDiviseurs;

namespace NombresParfaits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * DECLARATION DE VARIABLES
             * int numberToFind                   //nombre de nombre parfait à trouver
             * Liste<int> listDivisors           //liste de diviseurs
             * int isPerfect = 0                //compteur de nombre parfait trouvé
             * int sumDivisors                 //stock la somme des diviseurs
             * int number = 0                 // nombres que l'on test
             * 
             * TRAITEMENT
             * Ecrire "Bienvenu dan le programme d'affichage des nombres parfaits."
             * Ecrire "Combien de nombres parfaits souhaitez-vous afficher?"
             * nombre <-- GetUserInput()
             * Tant que isPerfect < à numberToFind
             *     sumDivisors <-- 1
             *      listDivisors <-- FindDivisor(numberToFind)
             *          pour chaque commonDivisors dans ListDivisors faire
             *              sumDivisors <-- sumDivisors + commonDivisors
             *          fin pour chaque
             *          si sumDivisors est égal à number
             *          ecrire nombre
             *          isPerfect <-- numberToFind + 1
             *          fin si
             * fin Tant que
             * 
             * AFFICHAGE
             * 
             * FONCTION
             * GetUserInput () : int
             * FindDivisor (int) :list<int>
             */

            int numberToFind = 0;               //nombre de nombre parfait à trouver
            List<int> listDivisors;            //liste de diviseurs
            int isPerfect = 0;                //compteur de nombre parfait trouvé
            int sumDivisors;                 //stock la somme des diviseurs
            int number = 1;

            Console.WriteLine("Bienvenu dan le programme d'affichage des nombres parfaits.");
            Console.WriteLine("Combien de nombres parfaits souhaitez-vous afficher?");

            numberToFind = TrouverDiviseurs.FindDivisors.GetUserInput();

            while (isPerfect < numberToFind)
            {
                sumDivisors = 1;
                listDivisors = TrouverDiviseurs.FindDivisors.FindDivisor(++number);
                foreach(int commonDivisors in listDivisors)
                {
                    sumDivisors = sumDivisors +commonDivisors; // sumDivisors == commonDivisors
                }
                if (sumDivisors == number)
                {
                    ++numberToFind;
                    Console.WriteLine($"{number} est des nombre parfait");
                }
            }
        }
    }
}