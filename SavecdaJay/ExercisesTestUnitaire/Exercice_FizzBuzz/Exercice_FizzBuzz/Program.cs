//Exercice: Kata FizzBuzz
//Le kata FizzBuzz nous demande d'ecrire un programme qui affiche, pour chaque nombre de 1 à 100:
//-"Fizz" si le nombre est un multiple de 3
//-"Buzz" si le nombre est un multiple de 5
//-"FizzBuzz" si nombre est un multiple de 3 et de 5
//-le nombre lui-même dans tous les autres cas  
using System.Security.Cryptography.X509Certificates;

namespace Exercice_FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine(MonExerciceFizzBuzz());
            }
        }
        public static string  MonExerciceFizzBuzz()
        {
            string result="";
            int nombre;
            for (nombre = 1; nombre <= 100; nombre++)
            {
                result+=AfficherLesNombres(nombre)+"\n";
            }
            return result;
            
            }
        public static string AfficherLesNombres(int nombre)
        {
            string result;
            if (nombre % 3 == 0 && nombre % 5 == 0)
            {
                result="FizzBuzz";
            }
            else if (nombre % 3 == 0)
            {
                result="Fizz";
            }
            else if (nombre % 5 == 0)
            {
                result="Buzz";
            }
            else
            {
                result= nombre.ToString();
            }
            return result;
        }
}
}