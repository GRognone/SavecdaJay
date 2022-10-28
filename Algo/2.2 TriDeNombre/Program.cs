int a;
int b;
Console.WriteLine("Veuillez-saisir un nombre a");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Veuillez-saisir un nombre b");
b = int.Parse(Console.ReadLine());


if (a > b)

{
    int temp = a;
    a = b;
    b = temp;
}

Console.WriteLine(a + " " + b + " ");