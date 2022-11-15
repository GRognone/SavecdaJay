/*
 * Soit "X" une valeur à convertir.
Formule °F vers °C : °C = (X − 32) 𝟓/9

Formule °C vers °F : °F = (X 𝟗/5) + 32

L'utilisateur saisit une valeur numérique comprise entre -459.67 et 5 000 000 suivi de l'unité de température : 
▪ C pour Celsius
▪ F pour Fahrenheit
La valeur et l'unité de température sont séparés par un espace (exemple: 32 C pour 32 degrés Celsius). Si la valeur est hors limite, 
l’utilisateur est invité à saisir une nouvelle valeur. 
Le programme affiche le résultat de la conversion sous forme de nombre réel double précision.
Pour information, le zéro absolu correspond à -459.67 Degrés Fahrenheit ou -273.15 degrés Celsius. 
En physique, rien ne peut être plus froid que le zéro absolu !
La température de la plus basse jamais enregistrée sur Terre est -95 degrés Celsius.
*/
using System.Formats.Asn1;

string userInput;
string[] tableConvert;
double value;
string unit;
double convertResult;
string getOut = "q";


Console.WriteLine("Veuillez entrer une valeur à convertir separé d'un espace suivi du symbole F pour convertir de fahrenheit en degrès ou C pour convertir du degres en fahrenheit");
userInput = Console.ReadLine();

if (!userInput.Equals(getOut))
{
    tableConvert = userInput.Split(" ");
    value = double.Parse(tableConvert[0]);

    if (tableConvert.Length > 1)
        {
        unit = tableConvert[1];
    }
    else
    {
        unit = "C";
    }
    if (unit.Equals("F"))
        {
        convertResult = FtoC(value);
        Console.WriteLine("La valeur " + userInput + "° degres fahrenheit en degre celsius est de " + convertResult + " C°.");
    }
    else 
    {
        convertResult = CtoF(value);
        Console.WriteLine("La valeur " + userInput + "° degres Celsius en degres fahrenheit est de " + convertResult + " F°.");
    }
}
Console.ReadLine();
static double CtoF(double _toConvert)
{
    double F = ((_toConvert*9)/5)+32;
    return F;
}
static double FtoC(double _toConvert) 
{
    double C = ((_toConvert + 32) * (5/9));
    return C;
}