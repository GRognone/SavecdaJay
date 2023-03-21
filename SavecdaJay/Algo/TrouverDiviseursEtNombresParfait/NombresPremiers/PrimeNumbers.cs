using TrouverDiviseurs;
namespace NombresPremiers
{
    internal class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int integerToTest = FindDivisors.GetUserInput();//creer une variable entier et utiliser la méthode créée dans l'autre projet

            List<int> divisors = FindDivisors.FindDivisor(integerToTest); // creer une liste et utiliser la methode créée dans l'autre projet

            if(divisors.Count == 0)
            {
                Console.WriteLine($"Le nombre {integerToTest} est un nombre premier.");
            }
            else
            {
                Console.WriteLine($"Le nombre {integerToTest} n'est pas premier.");
            }

            //autre solution pour afficher mais non conventionnel:
            //Console.WriteLine(Program.FindDivisors(Program.GetUserInput()).Count == 0 ? "Premier" : "Pas premier");
        }
    }
}

