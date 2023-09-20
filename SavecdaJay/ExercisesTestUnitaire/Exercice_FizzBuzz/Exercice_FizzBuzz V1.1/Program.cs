namespace Exercice_FizzBuzz_V1._1
{
    internal class Program
    {
         
        private const string ValeurRetourneeSiMultiplePremierMultiple = "Fizz";
        private const string ValeurRetourneSiMultipleDeSecondMultiple = "Buzz";
        private const int PremierMultiple = 3;
        private const int SecondMultiple = 5;

        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz(1, 100));
        }

        static string FizzBuzz(int debut, int fin)
        {
            string result = "";

            for (int i = debut; i <= fin; i++)
            {
                result += FizzBuzzPourUnNombre(i) + "\n";
            }

            return result;

        }

        static string FizzBuzzPourUnNombre(int nombre)
        {
            string result;
            if (nombre == 0)
            {
                result = nombre.ToString();
            }
            else if (VerifMultiplePremierNombre(nombre) && VerifMultipleSecondNombre(nombre))
            {
                result = ValeurRetourneeSiMultiplePremierMultiple + ValeurRetourneSiMultipleDeSecondMultiple;
            }
            else if (VerifMultiplePremierNombre(nombre))
            {
                result = ValeurRetourneeSiMultiplePremierMultiple;
            }
            else if (VerifMultipleSecondNombre(nombre))
            {
                result = ValeurRetourneSiMultipleDeSecondMultiple;
            }
            else
            {
                result = nombre.ToString();
            }

            return result;


        }

        static bool VerifMultiplePremierNombre(int nombre)
        {
            return nombre % PremierMultiple == 0;
        }

        static bool VerifMultipleSecondNombre(int nombre)
        {
            return nombre % SecondMultiple == 0;
        }
    }
}
