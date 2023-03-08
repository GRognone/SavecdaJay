// See https://aka.ms/new-console-template for more information


using ClassLibrary_Controles;
using System.Text.RegularExpressions;

bool ok1 = Controles.Controle_saisie_nom("AaZeRtGyUikojhuiguyguyk");
if (ok1)
{
    Console.WriteLine("c'est ok");
}
else
{
    Console.WriteLine("saisie incorrecte recommencez");
}

bool ok = Controles.Controle_Saisie_Code_Postal("15000");
if (ok)
{
    Console.WriteLine("c'est ok");
}
else
{
    Console.WriteLine("saisie incorrecte recommencez");
}




