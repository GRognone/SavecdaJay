using System;
using System.Drawing;

namespace _6._4_RechercheParDichotomie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ENONCE
            *Recherche par dichotomie d'un élément dans une table classée.
            *Soit une table contenant des prénoms, classés par ordre alphabétique
            *Nous désirons chercher l'indice de la case de la table où se trouve le prénom, si il s'y trouve.
            *Pour cela, nous utiliserons la méthode de dichotomie (voir ci-dessous la méthode).
            *Donnez l'algorithme de la procédure qui recherche, par dichotomie le numéro du prénom recherché ou zéro s'il n'y est pas.
            *Principe de la recherche par dichotomie:
            *Les prénoms sont classés par ordre alphabétique
            *On connaît le nombre d'éléments de la table
            *Algorithme:
            *On partitionne la table en 2 sous-tables et un élément médian, et, suivant le résultat de la comparaison de l'élément médian et 
            *du prénom recherché (plus grand, plus petit ou égal) on recommence la recherche sur une des 2 sous-tables, jusqu'à avoir 
             */

            /*PSEUDO CODE
             
             * DECLARATIONS
             
             * ecrire string userInput
             * lire userInput
             * declarer un tableau de string name
             * declarer un string searchName
             * declarer un int min
             * declarer un int max
             * declarer un int delta
             * declarer un int median
             * declarer boolean find
              
             * TRAITEMENT
             *  nom <-- (agathe, berthe, chloé, cunegonde, olga, raymonde, sidonie)
             *  min <-- 0
             *  max <-- longueur name
             *  searchName <-- olga
             *  delta <-- (max - min / 2)
             *  mediane <-- min + delta
             *  find <-- false
             *  find <-- name[median] egal searchName
             *  
             *  ecrire " Bonjour, vous êtes sur un programme de recherche de prénom par dichitomie"
             *  TANT QUE (nom[min+delta} est different de nomAChercher et delta different de 0)
             *  
             *  SI searchName est alphabethiquement avant name [median]
             *  max <-- median
             *  
             *  SINON
             *  min <-- median
             *  
             *  FINSI
             *  
             *  delta <-- (max - min / 2)
             *  mediane <-- min+delta
             *  find <-- name[median] egal searchName
             *  
             *  SI !find et delta ==0
             *      SI name[max] == searchName 
             *          median <-- max
             *          find <-- true
             *      FINSI
             *      
             *  FINSI
             *  FIN TANT QUE
             * 
             * AFFICHAGE
             * 
             * SI find est vrai 
             * Ecrire "le nom a été trouvé à l'indice", median
             * SINON
             * Ecrire "Le nom n'est pas présent dans le tableau"
             * FIN SI
             * 
             * FONCTION
            */

            string userInput;
            userInput = Console.ReadLine();
            string[] name = new[] { "agathe, berthe, chloé, cunegonde, olga, raymonde, sidonie" };
            string searchName;
            int min;
            int max;
            int delta;
            int median;
            bool find;













            Console.WriteLine("Hello, World!");
        }
    }
}