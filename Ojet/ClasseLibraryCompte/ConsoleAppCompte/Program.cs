// See https://aka.ms/new-console-template for more information
using ClasseLibraryCompte;

Console.WriteLine("Hello, World!");
Compte c = new Compte();

    Compte c1 =new Compte(16985, Console.ReadLine(), 1250324.04F, -500);
c1.ChangerDecouver(-5000);
Console.WriteLine("");
/*c.CrediterCompte(100);
Console.WriteLine(c);
bool ok = c.DebiterCompte(100000);
Console.WriteLine(c.ToString());

if (ok)
{
    Console.WriteLine("debit reussi");
}


else
{
    Console.WriteLine("debit pas reussi");
}*/