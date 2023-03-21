using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System;
using System.Reflection.Metadata;

namespace _6._2_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un palindrome est une chaîne de caractères que l'on peut lire identiquement de droite à gauche, et gauche à droite.
            Par exemple:
            • AA
            • 38783
            • LAVAL
            • LAVAL A ETE A LAVAL
            • ET LA MARINE VA VENIR A MALTE
            Soit un texte d'au moins 2 caractères (à contrôler).
            Ecrivez l'algorithme d'un programme permettant d'affirmer si cette phrase est un palindrome.
            Si la chaîne de caractères est vide, le message 'LA CHAINE EST VIDE' sera affiché.
            Proposez un jeu d'essai prévoyant les 3 cas suivants :
            ▪ la phrase est vide
            ▪ la chaîne de caractères n'est pas un palindrome
            ▪ la chaîne de caractères est un palindrome
            */


            string userInput;
            bool isAPalindrome = true;
            bool findWord = true;


            Console.WriteLine("Verifions si une chaine de caractère entrée par un utilisateur est un palindrome. Un palindrome est une chaîne de caractères que l'on peut lire identiquement de droite à gauche, et gauche à droite.");
            Console.WriteLine("Veuillez - saisir une chaine de caractere svp.");
            userInput = Console.ReadLine();
            string result = userInput.Replace(" ", "");// suppression des espaces.
            char[] resultArray = result.ToCharArray();// transforme string en tableau de char.
            if (result.Equals(""))
            {
                findWord = false;
                isAPalindrome = false;
                Console.WriteLine("La Phrase est vide.");
            }

            if (IsPalindrome = true)
            {
                Console.WriteLine("la chaîne de caractères est un palindrome");
            }
            else
            {
                Console.WriteLine("la chaîne de caractères n'est pas un palindrome");
            }

        }

        static bool IsPalindrome(char[] _resultArray)
        {
            int i = 0;
            while (i )
            {
                i++;
            }

            return true;
        }
    }
}