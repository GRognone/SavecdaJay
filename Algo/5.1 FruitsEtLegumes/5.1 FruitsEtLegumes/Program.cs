/*
 * L'utilisateur peut saisir des noms de légumes. Pour chaque légume, l'utilisateur précise un prix au kilo.
 * Lorsque l'utilisateur saisit la valeur "go", le programme affiche la liste des légumes avec leur prix ainsi que le légume le moins 
cher.
*/
string userInput;
List<string> priceCompare = new List<string>(); // creation d'une liste.
float value=0;
string start = "go";

Console.WriteLine("Nous allons repertorier des fruits et légumes ainsi que leurs prix au kg afin de connaitre le moins chère.");
do
{
    Console.WriteLine("Saisissez des noms de légumes ou fruits . Pour chaque légume ou fruits, precisez un prix au kilo svp.");

    userInput = Console.ReadLine();
    priceCompare.Add(userInput);
    foreach(string s in priceCompare)
    {
        Console.WriteLine(s);
    }




}
while (!userInput.Equals(start));
Console.WriteLine($"Le fruit ou légume le moins chère est : {value}");
Console.ReadLine();
Environment.Exit(0); //pour sortir du programme

