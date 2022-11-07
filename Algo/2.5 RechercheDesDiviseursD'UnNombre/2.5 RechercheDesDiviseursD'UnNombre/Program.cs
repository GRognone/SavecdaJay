// See https://aka.ms/new-console-template for more information

/*Lire un nombre entier et afficher tous ses diviseurs autres que 1 et lui-même.
 */
/*
 * ecrire un nombre N
 * lire nombre N
*/

try
{
    int N;
    int diviseur;
    bool pasDAutreQue1etN = false;

    Console.WriteLine("Nous allons trouver tous les diviseurs d'un nombre");
    Console.WriteLine("Veuillez saisir le nombre désiré svp.");
    N = int.Parse(Console.ReadLine());

    for (diviseur = 2; diviseur < (N - 1); diviseur++)
    {
        if (N % diviseur == 0)
        {
            Console.WriteLine(diviseur + " . ");
            pasDAutreQue1etN = true;
        }
    }
  
    if (!pasDAutreQue1etN)

    {
        Console.WriteLine("Il n'y a pas d'autres diviseurs que 1 et " + N);
    }
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(" Saisie Incorrecte !" + ex.Message);
}
