// See https://aka.ms/new-console-template for more information

/*
Soit une chaîne de caractères terminée par le caractère « . ». 
Donnez l'algorithme d'un programme qui compte le nombre d'occurrences d'une lettre donnée (« a » par exemple) dans cette 
chaîne.
Si la chaîne de caractères est vide ou n'est composée que du caractère « . », le message « LA CHAINE EST VIDE » sera affiché.
Proposez un jeu d'essai prévoyant les 3 cas suivants :
▪ La phrase est vide
▪ La lettre n'est pas présente
▪ La lettre est présente une ou plusieurs fois
*/

<<<<<<< Updated upstream
string phrasing;
char userInput;
int counter = 0;

Console.WriteLine("Entrez un texte de la longueur de votre choix svpterminez par un point");
phrasing = Console.ReadLine();
Console.WriteLine("Saisissez la lettre dont vous souhaitez connaitre la recurence dans le texte svp");
=======
string userInput;
char userFound;
int count = 0;

Console.WriteLine("Bonjour entrez une chaîne de caractères et terminez par un point svp.");
userInput = Console.ReadLine().ToLower();

if ((userInput.Equals(".")) || (userInput.Equals(" ")))
{
    Console.WriteLine("LA CHAINE EST VIDE");
}
else
    Console.WriteLine("Veuillez saisir le caractère recherché svp");
userFound = Console.ReadKey().KeyChar;
for (int i = 0; i < userInput.Length; i++)
{
    if (userInput[i] == userFound)
    {
        count++;
    }
}
if (count == 0)
{
    Console.WriteLine("La lettre recherchée n'est pas présente");
}
else
    Console.WriteLine(" La lettre recherchée est presente " + count + " fois dans la phrase.");
>>>>>>> Stashed changes
