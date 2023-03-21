/*
 * L’utilisateur est invité à saisir 2 nombres entier.
 * Le programme calcule la moyenne des 2 nombres et affiche le résultat sous forme de nombre réel double précision
 */

/*
 * DECLARATION DES VARIABLES
 * 
 * nb1 EST UN NOMBRE ENTIER
 * nb2 EST UN NOMBRE ENTIER.
 * result EST UN NOMBRE 
 * 
 * TRAITEMENT
 * 
 * ECRIRE "Programme de calcul de moyenne de 2 nombres"
 * ECRIRE "Veuillez saisir le nombre 1"
 * LIRE nb1
 * ECRIRE "Veuillez saisir le nombre 2"
 * LIRE nb2
 * 
 * result <-- (nb1 + nb2) / 2
 * result := (nb1 + nb2) / 2
 * 
 * AFFICHAGE DU/DES RESULTAT(S)
 * 
 * ECRIRE " La moyenne de ", nb1 ," et ",nb2 ," est de: ", RESULT
 */

using System.Runtime.ConstrainedExecution;
try
{
    int nb1;
    int nb2;
    double result;

    Console.WriteLine("Programme de calcul de moyenne de 2 nombres");
    Console.WriteLine("veuillez saisir un nombre svp.");
    nb1 = int.Parse(Console.ReadLine());
    Console.WriteLine("veuillez saisir un duxieme nombre svp)");
    nb2 = int.Parse(Console.ReadLine());

    result = (nb1 + nb2) / 2d; // le d après le 2 signifie que nous souhaitons le resultat double décimal.

    Console.WriteLine("La moyenne de " + nb1 + " et " + nb2 + " est de: " + result);
    Console.ReadLine();// pour que l'utilisateur clique pour fermer le programme.
}
catch
{
    Console.WriteLine("Erreur de saisie ! ");
    Console.ReadLine();
}