/*
 *L'utilisateur saisit une valeur comprise entre 0.01 et 1 000 000. Si la valeur est hors limite, l'utilisateur est invité à 
saisir une nouvelle valeur. Si la valeur est égale à "q", le programme se termine et se ferme. 
Formule km vers mi : 1 miles = 1.609 kilomètres
Le programme affiche le résultat de la conversion sous forme de nombre réel double précision.

L’utilisateur peut choisir le sens de la conversion.
Il saisit une valeur à convertir avec son unité de mesure (km ou mi).
Si aucune unité de mesure n’est indiquée, le programme considère la valeur en kilomètres.
*/

string distance;
string[] tableConvert;
double value;
string unit;
double convert;
string getOut = "q";
do
{
    Console.WriteLine("Entrez une valeur a convertir suivi d'un espace puis saisir l'unite de mesure  à convertir mi pour convertir miles en km et inversement.\nSi aucune unite saisie la valeur par defaut est km.");
    distance = Console.ReadLine().ToLower(); // "12 mi"

    if (!distance.Equals(getOut))
    {
        tableConvert = distance.Split(" ");

        value = double.Parse(tableConvert[0]); // transformation et recuperation valeur texte  "12 " en int

        if (tableConvert.Length > 1)
        { //  "length > 1 " case du chiffre saisi soit 0
            unit = tableConvert[1];
        }
        else
        {
            unit = "km";
        }
        if (unit.Equals("mi"))
        {
            convert = MilesToKms(value);
            Console.WriteLine("La distance " + distance + " miles convertie en Kilometres est de : " + convert + " kms.");
        }
        else
        {
            convert = KmsToMiles(value);

            Console.WriteLine("La distance " + distance + " Kimometres convertie en miles est de : " + convert + " miles.");
        }
    }

}
while (!distance.Equals(getOut));
Console.WriteLine("Au revoir !!");
Environment.Exit(0); //pour sortir du programme

Console.ReadLine();

static double MilesToKms(double _toconvert)
{
    double kms = _toconvert / 1.609;
    return kms;
}
static double KmsToMiles(double _toconvert)
{
    double miles = _toconvert * 1.609;
    return miles;
}
/* solution 2
//static double MilesToKms(double _toconvert)
{
    return _toconvert / 1.609;
}
static double KmsToMiles(double _toconvert)
{
    return _toconvert * 1.609;
}
*/

