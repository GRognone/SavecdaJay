/*
 * L’utilisateur saisit une unité de mesure (C ou F).
Il saisit ensuite une plage de valeurs (minimum, maximum).
Une fois les 2 valeurs saisies, le programme convertit toute la plage de valeur et affiche le résultat.
La commande « quit » permet de quitter le programme. 
Tant que cette commande n’est pas saisie, l’utilisateur peut continuer à faire des conversions.
*/

string userInput;
string unit;
double valueMin;
double valueMax;
double convert;
string getOut = "quit";

Console.WriteLine("Nous alons convertir une plage de valeur de température selon les consignes suivantes. Veuillez saisir une unité de mesure à convertir C pour convertir degres celsius en degres fahrenheit ou F pour convertir des degrès fahrenheit en degres celsius ou la commande 'quit' pour quitter le programme svp.");
do
{
    userInput = Console.ReadLine();

    if (!userInput.Equals(getOut))
    {
        if (userInput.ToUpper().Equals("C") || userInput.ToUpper().Equals("F"))
        {
            unit = userInput.ToUpper();
            valueMin = recupValue("Veuillez entrer une valeur minimale à convertir svp", unit);
            valueMax = recupValueMax("Veuillez saisir une valeur maximale à convertir svp", valueMin);
            if (userInput.ToUpper().Equals("C"))
            {
                Console.WriteLine($"La valeur minimale à convertir {valueMin} convertie en degres Fahrenheit est de {CtoF(valueMin)} F°");
                Console.WriteLine("La valeur maximale à convertir " + valueMax + " convertie en degres Fahrenheit est de " + CtoF(valueMax) + " F°");
            }
            else
            {
                Console.WriteLine("La valeur minimale à convertir " + valueMin + " convertie en degres Celsius est de " + FtoC(valueMin) + " C°");
                Console.WriteLine("La valeur maximale à convertir " + valueMax + " convertie en degres Celsius est de " + FtoC(valueMax) + " C°");
            }
            Console.WriteLine("tapez quit pour quitter ou C ou F pour continuer.");
        }
        else
        {
            Console.WriteLine("veuillez entrer C ou F svp.");
        }
    }
}
while (!userInput.Equals(getOut));
Console.WriteLine("Au Revoir");
Console.ReadLine();
Environment.Exit(0);

static double CtoF(double _toConvert) // cette fonction convertie les C° en F°
{
    double F = (_toConvert * 9) / 5 + 32;
    return F;
}
static double FtoC(double _toConvert) // cette fonction convertie les F° en C°
{
    double C = (_toConvert - 32) * (5D / 9);
    return C;
}
static double recupValue(string _text, string _unit) // cette foncion verifie la conformité du choix de l'unité et la valeur minimale
{
    double value = checkValue(_text);
 
    if (_unit.Equals("C"))
    {
        while (value < -273.15)
        {
            value = checkValue("Entrez une valeur supérieur à -273.15 svp");
        }
    }
    else
    {
        while (value < -459.67)
        {
            value = checkValue("Entrez une valeur supérieur à -459.67 svp");
        }
    }
    return value;
}
static double recupValueMax(string _text, double _valueMin) //cette fonction verifie la conformité que valeur max est > à valeur min
{
    double value = checkValue(_text); 
    while (value <= _valueMin)
    { 
        value = checkValue("Entrez une valeur supérieur à la valeur valeur minimale svp ");
    }
    return value;
}
static double checkValue(string _text) // cette fonction verifie que la valeur à convertir est bien un nombre
{
    Console.WriteLine(_text);
    string temp = Console.ReadLine();
    bool checkValid;
    do
    {
        if (temp.ToLower().Equals("quit"))
        {
            Console.WriteLine("Au Revoir");
            Console.ReadLine();
            Environment.Exit(0);
        }
        try
        {
            double.Parse(temp);
            checkValid = true;
        }
        catch (FormatException)
        {
            checkValid = false;
            Console.WriteLine("Erreur de saisie ce n'est pas un nombre !!!");
            temp = Console.ReadLine();
        }
    }
    while (!checkValid);
    return double.Parse(temp);
}