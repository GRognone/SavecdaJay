using ClasseBanque;

namespace Banques
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banque b = new Banque("Credit Agricole", "Mulhouse");
            b.AjouteCompte(1234, "Bob", 2000, 300);
            b.AjouteCompte(5678, "Jack", 5000, 100);
            if (b.Transferer(1234, 5678, 1000))
            {
                Console.WriteLine("Transfer effectué");
            }
            else
            {
                Console.WriteLine("Transfert impossible");
            }
            bool resultat = b.Transferer(1234, 5678, 5000);
        }
    }
}