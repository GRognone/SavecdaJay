/*
 * Il s'agit de dénombrer toutes les personnes d'âge strictement inférieur à 20 ans parmi un échantillon de 20 personnes. 
L’utilisateur est invité à saisir les 20 valeurs.
Décrivez l'algorithme qui affiche le nombre de jeunes et codez la solution.
 */
/*
string[] age = new string[20];
string userInput;
int[] value = new int[20];
int young = 0;
int old = 0;
int asMuch = 0;
Console.WriteLine("Nous allons dénombrer sur un pannel de 20 personnes combien ont plus de 20 ans, moins de 20 ans et 20 ans pile.");
Console.WriteLine("Veuillez saisir l'age de 20 personnes en les séparants par un espace svp.");

userInput = Console.ReadLine().Trim(); // .Trim sert à enlever les espaces vide avant et apres la saisie

age = userInput.Split(" ");

for (int i = 0; i < age.Length; i++)
{
    value[i] = int.Parse(age[i]);
}
Console.WriteLine(value.ToString());
foreach (int element in value)
{
    if (element < 20)
    {
        young++;
    }
    else if (element > 20)
    {
        old++;
    }
    else
    {
        asMuch++;
    }
}
if (young > 0 && old == 0 && asMuch == 0)
{
    Console.WriteLine("Toutes les personnes ont moins de 20 Ans");
}
else if (young == 0 && old > 0 && asMuch == 0)
{
    Console.WriteLine("Toutes les personnes ont plus de 20 Ans");
}
else if (young == 0 && old == 0 && asMuch > 0)
{
    Console.WriteLine("Toutes les personnes ont 20 Ans");
}
else
{
    Console.WriteLine($"il y a {young} de moin de 20 Ans, {old} personnes de plus de 20 Ans et {asMuch} personnes qui ont 20 ans.");
}
*/

// version 2.
string[] age = new string[20];
string userInput;
int[] value = new int[20];
int young = 0;
int old = 0;
int asMuch = 0;
Console.WriteLine("Nous allons dénombrer sur un pannel de 20 personnes combien ont plus de 20 ans, moins de 20 ans et 20 ans pile.");


getUserInput();
convertStringToInt();
sorting();
showResult();

void getUserInput()
{
    Console.WriteLine("Veuillez saisir l'age de 20 personnes en les séparants par un espace svp.");
    userInput = Console.ReadLine().Trim(); // .Trim sert à enlever les espaces vide avant et apres la saisie

    age = userInput.Split(" ");
}
void convertStringToInt()
{
    for (int i = 0; i < age.Length; i++)
    {
        value[i] = int.Parse(age[i]);
    }
}
void sorting()
{
    foreach (int element in value)
    {
        if (element < 20)
        {
            young++;
        }
        else if (element > 20)
        {
            old++;
        }
        else
        {
            asMuch++;
        }
    }
}
void showResult()
{
    if (young > 0 && old == 0 && asMuch == 0)
    {
        Console.WriteLine("Toutes les personnes ont moins de 20 Ans.");
    }
    else if (young == 0 && old > 0 && asMuch == 0)
    {
        Console.WriteLine("Toutes les personnes ont plus de 20 Ans.");
    }
    else if (young == 0 && old == 0 && asMuch > 0)
    {
        Console.WriteLine("Toutes les personnes ont 20 Ans.");
    }
    else
    {
        Console.WriteLine($"il y a {young} de moins de 20 Ans, {old} personnes de plus de 20 Ans et {asMuch} personnes qui ont 20 ans.");
    }
}
