
int nombrea;
int nombreb;
int nombrec;


//SAISIE
//ecrire (" Veuillez-saisir le nombre a")
Console.WriteLine("Veuillez-saisir ne nombre a");
//lire nombrea
#pragma warning disable CS8604 // Possible null reference argument for parameter 's' in 'int int.Parse(string s)'.
nombrea =int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument for parameter 's' in 'int int.Parse(string s)'.
//ecrire ("veuillez-saisir le nombre b ")
Console.WriteLine("Veuillez-saisir ne nombre b");
//lire nombreb
#pragma warning disable CS8604 // Possible null reference argument for parameter 's' in 'int int.Parse(string s)'.
nombreb = int.Parse(Console.ReadLine());;
#pragma warning restore CS8604 // Possible null reference argument for parameter 's' in 'int int.Parse(string s)'.

//ecrire ("veuillez-saisir le nombre b ")
Console.WriteLine("Veuillez-saisir ne nombre c");
//lire nombreb
#pragma warning disable CS8604 // Possible null reference argument for parameter 's' in 'int int.Parse(string s)'.
nombrec = int.Parse(Console.ReadLine());;
#pragma warning restore CS8604 // Possible null reference argument for parameter 's' in 'int int.Parse(string s)'.

//TRAITEMENT
if ((nombrea < nombreb) && (nombreb < nombrec))
{
    Console.WriteLine("a<b<c");
}
else if ((nombrea < nombreb) && (nombreb > nombrec) && (nombrea < nombrec))
{
    Console.WriteLine("a<c<b");
}
else if ((nombreb < nombrea) && (nombrea < nombrec))
{
    Console.WriteLine("b<a<c");
}
else if ((nombreb < nombrea) && (nombrea > nombrec) && (nombreb < nombrec))
{
    Console.WriteLine("b<c<a");
}
else if ((nombrec < nombrea) && (nombrea < nombreb) && (nombrec < nombreb))
{
    Console.WriteLine("c<a<b");
}
else if ((nombrec < nombrea) && (nombrea > nombreb) && (nombrec < nombreb))
{
    Console.WriteLine("c<b<a");
}

	
