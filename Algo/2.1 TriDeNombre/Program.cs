int a;
int b;
int c;
Console.WriteLine("Veuillez-saisir un nombre a");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Veuillez-saisir un nombre b");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Veuillez-saisir un nombre c");
c = int.Parse(Console.ReadLine());

if (a > b)
{
    int temp = a;
    a = b;
    b = temp;
    if (a > c)// a a pris la valeur de b
    {
        temp = a;
        a = c;
        c = temp;
    }
    if (b > a)
    {
        temp = c;
        c = b;
        b = temp;

    }
    else if (a > c)
    {

        temp = a;
        a = c;
        c = temp;
        if (b > c)
        {
            temp = c;
            c = b;
            b = temp;
        }
    }
    else if (b > c)
    {
        temp = b;
        b = c;
        c = temp;
    }
}
    Console.WriteLine(a + " " + b + " " + c);



