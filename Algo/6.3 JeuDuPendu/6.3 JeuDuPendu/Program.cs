/*
 * L'algorithme lit un mot proposé par un premier joueur. 
Ce mot a une longueur minimum de 5 caractères (à contrôler). 
L'algorithme affiche ensuite le mot où toutes les lettres sauf la première et la dernière sont remplacées par un tiret. Un 
deuxième joueur propose des lettres une à une. 
Chaque fois que la lettre proposée se trouve dans le mot, l'algorithme remplace les tirets qui remplaçaient cette lettre et 
réaffiche le mot. Le second joueur a droit à un maximum de 6 erreurs pour retrouver toutes les lettres.
 */


string player1Input;
char[] converPlayer1ToChar;
char[] tableWordToFind;
int test = 6;


char player2Input;

Console.WriteLine("Jouons au jus du pendu, le premier joueur entre un mot de 5 lettres minimum  que le deuxième joueur doit trouver en 6 essais");
wordToFind();
AffichageDuTableau(tableWordToFind);

Console.Clear();
Console.WriteLine("Joueur 2 à vous de jouer tentez votre chance.");



void wordToFind()
{
    Console.WriteLine("Joueur 1 veuillez-saisir un mot de 5 lettres minimum svp.");
    player1Input = Console.ReadLine();
    converPlayer1ToChar = player1Input.ToCharArray(); // convertie l'entrée du 1er joueur string en char
    tableWordToFind = converPlayer1ToChar; //recuperation du mot avant cahe des lettres à trouver
    for(int i = 1; i < tableWordToFind.Length - 1; i++) // transformation des lettres à trouver par des tirets 
    {
        tableWordToFind[i] = '_';
    }
}//Sert à entrer un mot et le scinder en caracteres et cacher les lettres à trouver

static void AffichageDuTableau(char[]_tableWordToFind)
{
    foreach (int i in _tableWordToFind)
    {
        Console.Write((char)i);
    }
    Console.WriteLine();
} // faire un saut de ligne