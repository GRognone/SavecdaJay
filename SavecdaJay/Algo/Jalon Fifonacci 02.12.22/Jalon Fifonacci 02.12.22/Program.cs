namespace Jalon_Fifonacci_02._12._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int position = 2;
            int n;
            string resultat = "0\n1";
            long nbPrecedent = 0;
            long nbCourant = 1;
            long nbSuivant;

            Console.WriteLine("Nous allons afficher les preniers nombre de la suite de Fibonacci en fonction du nombre dinal que vous aurrez choisi.");
            Console.WriteLine("Veuillez-saisir un nombre svp.");
            n = int.Parse(Console.ReadLine());

            if (n > 2)
            {
                while (position < n)
                {
                    nbSuivant = nbPrecedent + nbCourant;
                    resultat = resultat+ "\n"+ nbSuivant;
                    nbPrecedent = nbCourant;
                    nbCourant = nbSuivant;
                    //position = position + 1;
                    position++;
                }
            }
            else
            {
                n = 2;
            }
            Console.WriteLine($"Les {n} premiers nombres de la suite de Fibonacci sont \n" + resultat);

        }
    }
}