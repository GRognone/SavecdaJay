int a;
int b;
int c;
Console.WriteLine("Veuillez-saisir un nombre a");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Veuillez-saisir un nombre b");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Veuillez-saisir un nombre c");
c = int.Parse(Console.ReadLine());

if (a < b)
{
    int temp = a;
    a = b;
    b = temp;
}

else if (b < c)
{
    int temp = b;
    b = c;
    c = temp; 
}
else if (a < c)
{
    int temp = c;
    c = a;
    a = temp;
}
Console.WriteLine(a + " " + b + " " + c);




