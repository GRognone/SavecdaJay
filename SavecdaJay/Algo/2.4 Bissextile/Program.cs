int a;
Console.WriteLine("Veuillez saisir une annee svp.");
a = int.Parse(Console.ReadLine());

/*Déterminer si l'année A est bissextile. Si A n'est pas divisible par 4, l'année n'est pas bissextile.
Si A est divisible par 4, l'année est bissextile sauf si A est divisible par 100 et pas par 400.
Afficher le message « Bissextile » ou « Non bissextile » suivant le cas.
*/
if (((a % 4 == 0) && (a % 100 != 0)) || (a % 400 == 0))
{
    Console.WriteLine("L'année " + a + " est bissextile");
}
else
{
    Console.WriteLine("L'année " + a + " n'est pas bissextile");
}
