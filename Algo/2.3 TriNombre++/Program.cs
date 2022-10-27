double a;
double b;
double c;

Console.WriteLine("Veuillez saisir un nombre entier svp");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Veullez sasir un second nombre entier svp");
b = double.Parse(Console.ReadLine());  
Console.WriteLine("Veuillez saisir un troisieme nombre entier svp");
c = double.Parse(Console.ReadLine());


double min, med, max;


if (a < b)
{
    if (b < c)
    {
        min = a;
        med = b;
        max = c;
    } else
    {
        if (a < c)
        {
            min = a;
            med = c;
            max = b;
        } else
        {
            min = c;
            med = a;
            max = b;
        }
    }
} else
{
    if (a < c)
    {
        min = b;
        med = a;
        max = c;
    }
    else
    {
        if (b < c)
        {
            min = b;
            med = c;
            max = a;
        }
        else
        {
            min = c;
            med = b;
            max = a;
        }
    }
}
a = min;
b = med;
c = max;

Console.WriteLine(String.Format("{0}<={1}<={2}", a, b, c));
