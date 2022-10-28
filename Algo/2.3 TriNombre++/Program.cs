/*double[] numbers = new double[3];

Console.WriteLine("Veuillez saisir un nombre entier svp");
numbers[0] = double.Parse(Console.ReadLine());
Console.WriteLine("Veullez sasir un second nombre entier svp");
numbers[1] = double.Parse(Console.ReadLine());  
Console.WriteLine("Veuillez saisir un troisieme nombre entier svp");
numbers[2] = double.Parse(Console.ReadLine());
numbers = trierTableau(numbers);
foreach(double number in numbers)
{
    Console.WriteLine(number);
}

static double[] trierTableau(double[] tableauATrier)
{
    double tmp;
    for (int i = 0; i < tableauATrier.Length - 1; i++)
    {
        for (int j = i; j < tableauATrier.Length; j++)
        {
            if (tableauATrier[j] < tableauATrier[i])
            {
                tmp = tableauATrier[j];
                tableauATrier[j] = tableauATrier[i];
                tableauATrier[i] = tmp;
            }
        }
    }
    return tableauATrier;
}*/
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
}
else
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


