int a;
int maj;
int min;
Console.WriteLine("Veuillez-entrer votre age svp");
a = int.Parse(Console.ReadLine());
if ((a > 0) && (a < 18))
{
    Console.WriteLine("Vous êtes mineur.");
}
else if ((a > 0) && (a >= 18))
{
    Console.WriteLine("Vous etes majeur.");
}
else
{
    Console.WriteLine("Vous n'etes pas encore né");
}