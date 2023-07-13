using Exo_Calculs;

namespace Calcul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exo_Calculs.Expression ex1 = new Addition(new Nombre(3), new Nombre(2));
            double resultat1 = ex1.Calculer();
            Console.WriteLine("resultat 1 = "+resultat1);

            Exo_Calculs.Expression ex2 = new Addition(new Nombre(2), new Addition(new Nombre(3), new Nombre(89)));
            double resultat2 = ex2.Calculer();
            Console.WriteLine("resultat 2 = " + resultat2);

            Exo_Calculs.Expression ex3 = new Soustraction(new Nombre(7), new Nombre(8));
            double resultat3 = ex3.Calculer();
            Console.WriteLine("resultat 3 = " + resultat3);

            Exo_Calculs.Expression ex4 = new Soustraction(new Nombre(3), new Soustraction(new Nombre(6), new Nombre(7)));
            double resultat4 = ex4.Calculer();
            Console.WriteLine("resultat 4 = " + resultat4);
        }
    }
}