namespace MonBuzzFizz
{
    public static class Fizz
    {
        private const int PremiereValeur = 3;
        private const int SecondeValeur = 5;

        public static string MonExerciceFizzBuzz()
        {
            string result = "";
            int nombre;
            for (nombre = 1; nombre <= 100; nombre++)
            {
                result += FizzBuzzPourUnNombre(nombre) + "\n";
            }
            return result;
        }

       

        public static string FizzBuzzPourUnNombre(int nombre)
        {
            if (nombre % PremiereValeur == 0 && nombre % SecondeValeur == 0)
            {
                return "BuzzFizz";
            }
            else if (nombre % PremiereValeur == 0)
            {
                return "Fizz";
            }
            else if (nombre % SecondeValeur == 0)
            {
                return "Buzz";
            }
            return nombre.ToString();
        }

    }
}