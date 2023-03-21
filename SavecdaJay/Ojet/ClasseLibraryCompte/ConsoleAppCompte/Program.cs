// See https://aka.ms/new-console-template for more information
using ClasseLibraryCompte;

Compte c = new Compte();
Compte c1 = new Compte(12345, "Luc", 100, -500);

///Crediter un compte d'un montant

c1.CrediterCompte(50);
Console.WriteLine(c1.ToString());

/// Verifier si le debit peut être effectué en fonction du solde.

bool ok = c1.DebiterCompte(600);
Console.WriteLine(c1.ToString());
if (ok)
{
    Console.WriteLine("Debit réusi !");
}
else
{
    Console.WriteLine("Debit pas réussi");
}
/// transfer de compte à compte

Compte c2 = new Compte(12345, "toto", 1000, -500);
Compte c3 = new Compte(4567, "titi", 2000, -1000);

Console.WriteLine(c2.ToString());
Console.WriteLine(c3.ToString());
bool resultat = c2.TransfererMontantVersAutreCompte(1300, c3);
Console.WriteLine(c2.ToString());
Console.WriteLine(c3.ToString());

///Comparaison du solde entre 2 comptes

Compte c4 = new Compte(89123, "tata", 1000, -500);
Compte c5 = new Compte(56789, "tutu", 2000, -1000);
if (c4.Superieur(c5))
{
    Console.WriteLine("Superieur");
}
else
{
    Console.WriteLine("Inferieur");
}

