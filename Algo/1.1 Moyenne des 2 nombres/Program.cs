float a;
float b;
float moyenne;

Console.WriteLine("veuillez saisir un nombre svp.");
a = float.Parse(Console.ReadLine());
Console.WriteLine("veuillez saisir un duxieme nombre svp)");
b = float.Parse(Console.ReadLine());

moyenne = (a + b) / 2;

Console.WriteLine("La moyenne est de " + moyenne);
Console.ReadLine();