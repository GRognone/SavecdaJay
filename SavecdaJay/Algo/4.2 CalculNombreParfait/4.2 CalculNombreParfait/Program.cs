/*
 * On souhaite écrire un programme de calcul des N premiers nombres parfaits. 
Un nombre est dit parfait s’il est égal à la somme de ses diviseurs, 1 compris. 
Exemple :
6 = 1+2+3 
6 est un nombre parfait. 
 
L'algorithme retenu contiendra deux boucles imbriquées. Une boucle de comptage des nombres parfaits qui s'arrêtera lorsque 
le décompte sera atteint, la boucle interne ayant vocation à calculer tous les diviseurs du nombre examiné d'en faire la somme 
puis de tester l'égalité entre cette somme et le nombre. 
Ecrivez le programme complet qui affiche les N premiers nombres parfaits.
*/
int n;
int diviseur;
int isPerfect = 0;
int number = 1;
int totalDivisor = 0;
Console.WriteLine("Combien souhaitez-vous afficher de nombre parfait?");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Les " + n + " nombres parfait sont les suivants : ");

while (isPerfect < n)
{

    for (diviseur = 1; diviseur < (number - 1); diviseur++)
    {
        if (number % diviseur == 0)
        {
            totalDivisor += diviseur;
        }
    }
    if (totalDivisor == number)
    {
        isPerfect++;
        Console.WriteLine(number + " ");//*valeur du nombre parfait trouve
    }
    totalDivisor = 0;//** rajouter pour reinitialiser somme diviseurs
    number++;
}
