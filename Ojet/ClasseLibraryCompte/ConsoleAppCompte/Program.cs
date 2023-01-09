// See https://aka.ms/new-console-template for more information
using ClasseLibraryCompte;

Compte c = new Compte();
Compte c1 = new Compte(16985, "Luc", 100.00F, -500);
c1.CrediterCompte(50);
Console.WriteLine(c1);
bool ok = c1.DebiterCompte(-601);
Console.WriteLine(c1.ToString());
if (ok)
{
    Console.WriteLine("Debit réusi !");
}
else
{
    Console.WriteLine("Debit pas réussi");
}

