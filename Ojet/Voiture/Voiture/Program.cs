namespace Voiture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Roue roueParDefaut = new Roue();
            Roue roueMaRoue = new Roue("250/40/17", true);
            Roue roueCopiee = new Roue(roueMaRoue); 

            Voiture maCaisse= new Voiture();
            Console.WriteLine(maCaisse.Demarrer());
            int a = 0;
        }
    }
}