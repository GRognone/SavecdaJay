using System.Data;

namespace OpenClassroomTestUnitaires
{
    internal class Program
    {
        //public static int Addition(int a, int b) 
        //{
        //    return a + b;
        //}

        //static void Main(string[] args)
        //{
        //    int a = 1;
        //    int b = 1;


        //    int resultat = Addition(a, b);


        //    if (resultat != 3)
        //        Console.WriteLine("Le test a raté");
        //    else
        //        Console.WriteLine("Le test est ok");
        //}

        static void Main(string[] args)
        {
            string phrase1 = "";
            if (CompteMots(phrase1) != 0)
                Console.WriteLine("Echec du test");
            else
                Console.WriteLine("Le test est ok");
            string phrase2 = "mot";
            if (CompteMots(phrase2) != 1)
                Console.WriteLine("Echec du test");
            string phrase3 = "deux mots";
            if (CompteMots(phrase3) != 2)
                Console.WriteLine("Echec du test");
            string phrase4 = "trois petits mots";
            if (CompteMots(phrase4) != 3)
                Console.WriteLine("Echec du test");
            string phrase5 = " des  espaces en trop    ";
            if (CompteMots(phrase5) != 4)
                Console.WriteLine("Echec du test");

        }

        private static int CompteMots(string phrase)
        {
         
            var mots = phrase.Split(' ');
            return mots.Count(mot => mot.Length > 0);

        }
    }
}