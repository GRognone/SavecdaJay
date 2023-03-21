float s;
float i;
float n;
float ins;
float ic;

Console.WriteLine("Veuillez-saisir la somme investie au départ svp");
s=float.Parse(Console.ReadLine());
Console.WriteLine("Veuillez-saisir le taux d'interets");
i=float.Parse(Console.ReadLine());
Console.WriteLine("Veuillez-saisir le nombre d'années");
n=float.Parse(Console.ReadLine());
ins=s*(1+n*i/100);
Console.WriteLine("La valeur acquise avec in intéret simple est de "+ins);
ic=(float)(s*Math.Pow(1+i,n/100));
Console.WriteLine("La valeur acquise avec un interet composé est de "+ic);