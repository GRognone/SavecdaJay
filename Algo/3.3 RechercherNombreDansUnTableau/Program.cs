// See https://aka.ms/new-console-template for more information

/*
 * Soit un tableau de nombres entier triés par ordre croissant.
Chercher si un nombre donné N figure parmi les éléments. 
Si oui, afficher la valeur de l'indice correspondant. Sinon, afficher « 404 Not found ».

si  mon entree utilisateur se trouve dans le tableau affiche le

Si mon entrée utilisateur est égale à la valeur à l'indice "I" de mon tableau "array"
-> J'en conclu que j'ai trouvé l'indice demandé
--> donc je valide que je l'ai trouvé

 */

//déclaration de variable
int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int userInput = 0;
int indice=0;
bool found = false;
bool userInputValid=false;

//Saisie et vérification utilisateur
do { 
Console.WriteLine("Saisissez un chiffre !");
    try
    {
        userInput = int.Parse(Console.ReadLine());
        userInputValid = true;  
    }
    catch (Exception e)
    {
        Console.WriteLine("RENTRE UN TRUC CORRECTE NON DE DIEU");
    }
}
while (!userInputValid);

//Traitement des données et recherche du chiffre dans un tableau
for (int i = 0; i < array.Length; i++)
{
    if (userInput == array[i])
    {
        indice = i;
        found = true;
    }
}

//affichage
if (found)
{
    Console.WriteLine("Le chiffre " + userInput + " se trouve dans le tableau à l'indice ! " + indice);
}
else
Console.WriteLine("404 Not found");