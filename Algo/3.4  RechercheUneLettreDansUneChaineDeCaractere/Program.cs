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

string phrasing;
char userInput;
int counter = 0;

Console.WriteLine("Entrez un texte de la longueur de votre choix svpterminez par un point");
phrasing = Console.ReadLine();
Console.WriteLine("Saisissez la lettre dont vous souhaitez connaitre la recurence dans le texte svp");
