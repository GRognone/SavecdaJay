namespace TrouverDiviseurs
{
    /*recherche des diviseurs d'un nombre entier
             * si le reste égale à zero.
             * DECLARATION DES VARIABLES
             *string inputUser
             *entier inputConvert
             *entier i
             *liste entiers [] diviseurs
             *TRAITEMENT
             *ecrire ("Touvons tous les diviseurs d'un nombre entier")
             *ecrire ("Entrez un nombre entier svp")
             *faire
             *      lire(userInput)
             * Tant que inputConvert(userInput)  impossible
             * inputConvert = int.Parse(userInput)
             * pour i de 1 à inputConvert %2,i++
             *      si inputConverti==0
             *          ajouter i à diviseurs
             *AFFICHAGE
             *Ecrire (Les diviseurs de inputUser son ", diviseurs)
             *
             *
            */
    public class FindDivisors
    {

        static void Main(string[] args)
        {

            int inputConvert;

            List<int> divisor = new List<int>();
            Console.WriteLine("Touvons tous les diviseurs d'un nombre entier");

            inputConvert = GetUserInput();
            divisor = FindDivisor(inputConvert);

            foreach (int i in divisor)

                Console.WriteLine($"L'ensemble des diviseurs sont :{i}");
        }

        /// <summary>
        /// Retourne la saisie utilisateur convertie de" string en int
        /// </summary>
        /// <returns>La saisie utilisateur sous forme d'entier</returns>
        public static int GetUserInput()
        {
            string userInput;
            int inputConvert;
            do
            {
                Console.WriteLine("Entrez un nombre entier svp.");
                userInput = Console.ReadLine();
            }
            while (!int.TryParse(userInput, out inputConvert));
            return inputConvert;
        }

        public static int GetUserInputV1()
        {
            Console.WriteLine("Entrez un nombre entier svp.");
            string userInput = Console.ReadLine();
            int inputConvert;

            if(int.TryParse(userInput, out inputConvert))
            {
                return inputConvert;
            } 
            return GetUserInputV1();
        } // autre solution de fonction recuperation userInput en recursif
        public static int GetUserInputV2()
        {
            Console.WriteLine("Entrez un nombre entier svp.");
            return(int.TryParse(Console.ReadLine(),out int userInput) ? userInput: GetUserInputV2());
        } // autre solution de fonction recuperation userInput en recursif ternel


        /// <summary> //surcharge de methode
        /// Retourne les diviseurs d'un nombre donné
        /// </summary>
        /// <param name="userInput">Le nombre à évaluer</param>
        /// <returns></returns>
        private static List<int> FindDivisor(string userInput)
        {
            return FindDivisor(Convert.ToInt32(userInput));
        }

        /// <summary>
        /// Retourne les diviseurs d'un nombre donné
        /// </summary>
        /// <param name="userInput">Le nombre à évaluer</param>
        /// <returns></returns>

        public static List<int> FindDivisor(int userInput)
        {
            List<int> divisor = new List<int>();
            int i;
            int limit = userInput / 2;// max du parcour de diviseurs possibles
            for (i = 2; i <= limit; i++)
            {
                if (userInput % i == 0)
                {
                    divisor.Add(i);
                }
            }
            return divisor;
        } // sert à effectuer le calcul
        

    }
}