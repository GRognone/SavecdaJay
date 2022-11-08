// See https://aka.ms/new-console-template for more information

/*Lire un nombre N et déterminer s’il est un nombre premier. Un nombre premier n'est divisible que par 1 et par lui-même.*/
using System;

try
{
    int N;
    int diviseur;
    bool estUnNombrePremier = false;

    Console.WriteLine("Déterminons si un nombre choisi est premier");
    Console.WriteLine("Veuillez saisir un nombre à tester svp");
    N=int.Parse(Console.ReadLine());

    if (N > 1)
    {
        estUnNombrePremier = true;

        if (N % 2 == 0)
        { 
            if (N != 2)
            {
                estUnNombrePremier = false;
            }
        }
        else
        { 
            diviseur = 3;
            while (N % diviseur != 0 && diviseur < N)
            {
                diviseur += 2;
            }
            if (diviseur != N)
            {
                estUnNombrePremier = false;
            }
        }
    }
    if (estUnNombrePremier)
    {
        Console.WriteLine(N + " est un nombre premier");
    }
    else
    {
        Console.WriteLine(N + " n'est pas un nombre permier");
    }
    Console.ReadLine();

}
catch (Exception ex)
{
    Console.WriteLine(" Saisie Incorrecte !" + ex.Message);
}