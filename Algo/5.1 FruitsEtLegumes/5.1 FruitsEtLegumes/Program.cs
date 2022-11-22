/*
 * L'utilisateur peut saisir des noms de légumes. Pour chaque légume, l'utilisateur précise un prix au kilo.
 * Lorsque l'utilisateur saisit la valeur "go", le programme affiche la liste des légumes avec leur prix ainsi que le légume le moins 
cher.
*/
using System.Globalization;

string userInput;
List<string> priceCompare = new List<string>(); // creation d'une liste
string start = "go";

Console.WriteLine("Nous allons repertorier des fruits et légumes ainsi que leurs prix au kg afin de connaitre le moins chère.");
do
{
    Console.WriteLine("Saisissez des noms de légumes ou fruits . Pour chaque légume ou fruits, precisez un prix au kilo svp.");
    userInput = Console.ReadLine();
    priceCompare.Add(userInput);

    foreach(string s in priceCompare)
    {
        Console.WriteLine(s); // affichage de la liste avec prix 
    }
}
while (!userInput.Equals(start));
int index =0;
float temp=0;
float price;
string name="";
for ( int i = 0; i < priceCompare.Count-1; i++)
{
    price = float.Parse(priceCompare[i].Split(' ')[1],NumberStyles.Any, CultureInfo.InvariantCulture); // recup prix
    if (temp == 0)
    {
        temp = price;// stockage du 1er prix   
        name = priceCompare[i].Split(' ')[0];// recuperation du nom
    }
    else if (temp > price) // comparaison des prix
    {
        temp = price;
        index = i;
        name = priceCompare[i].Split(' ')[0];// recuperation du nom
    }
}

Console.WriteLine($"Le fruit ou légume le moins chère est : {name}");
Console.ReadLine();
Environment.Exit(0); //pour sortir du programme