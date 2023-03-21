using TestClasse;

internal class Program
{
    private static void Main(string[] args)
    {
        Personne unePersonne;
        unePersonne = new Personne("Gates", "Bill", 62);

        unePersonne.age = 18;
        Console.WriteLine(unePersonne.Info());

         int total = 0;
        for(int i = 0; i<4; i++) 
        { 
            total+= i;
            Console.WriteLine(total);
        }

        Personne personne2;

        personne2 = new Personne("Skywalker", "Luc", 18);

        Console.WriteLine(personne2.Info()); 5
        // solution 
        /*  unePersonne.SetAge(18);

          Console.WriteLine(unePersonne.GetAge());
      }*/
    }
}