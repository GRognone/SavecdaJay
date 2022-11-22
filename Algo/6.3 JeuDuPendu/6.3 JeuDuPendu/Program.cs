/*
 * L'algorithme lit un mot proposé par un premier joueur. 
Ce mot a une longueur minimum de 5 caractères (à contrôler). 
L'algorithme affiche ensuite le mot où toutes les lettres sauf la première et la dernière sont remplacées par un tiret. Un 
deuxième joueur propose des lettres une à une. 
Chaque fois que la lettre proposée se trouve dans le mot, l'algorithme remplace les tirets qui remplaçaient cette lettre et 
réaffiche le mot. Le second joueur a droit à un maximum de 6 erreurs pour retrouver toutes les lettres.
 */


string player1Input;
char[] convertPlayer1ToChar;
char[] tableWordToFind;
char player2Input;
int test = 6;
bool victory = false;

Console.WriteLine("Jouons au jus du pendu, le premier joueur entre un mot de 5 lettres minimum  que le deuxième joueur doit trouver en 6 essais");
wordToFind();
AffichageDuTableau(tableWordToFind);


Console.WriteLine("Veuillez appuyer sur une touche et appelez joueur 2 svp");
Console.ReadKey();
Console.Clear();

Console.WriteLine("Joueur 2 à vous de jouer tentez votre chance.");
letterToTry();


void wordToFind()
{
    do
    {
        Console.WriteLine("Joueur 1 veuillez-saisir un mot de 5 lettres minimum svp.");
        player1Input = Console.ReadLine();
    }
    while (player1Input.Length < 5);
    {
        convertPlayer1ToChar = player1Input.ToCharArray(); // converti l'entrée du 1er joueur string en tableau de char
        tableWordToFind = player1Input.ToCharArray(); ; //nouveau tableau pour afficher le mot caché!( ne pas comaprer avec svp!!!)
    }
    for (int i = 1; i < tableWordToFind.Length - 1; i++) // transformation des lettres à trouver par des tirets 
    {
        tableWordToFind[i] = '_';
    }
}//Sert à entrer un mot et le scinder en caracteres et cacher les lettres à trouver

void letterToTry()
{
    Console.WriteLine("Joueur 2 vous avez droit à 6 erreurs");
    bool correctLetter;
    int cpt =0;
    while (victory == false)
    {
        Console.WriteLine("Veuillez saisir une lettre svp.");
        player2Input = Console.ReadLine()[0];
        correctLetter = false;
        for (int i = 1; i < tableWordToFind.Length - 1; i++)
        {
            if (player2Input == convertPlayer1ToChar[i])
            {
                tableWordToFind[i] = convertPlayer1ToChar[i];
                cpt++;
                correctLetter = true;

                if (areEquals(tableWordToFind,convertPlayer1ToChar))
                {
                    victory = true;
                    Console.WriteLine("\nVous avez gagné !!!");
                }
            }
        }
        Console.WriteLine(tableWordToFind);
        if (correctLetter == false)
        {
            test--;
            Console.WriteLine($" Il vous reste {test} tentatives.");
        }
        if (test < 1)
        {
            victory = false;
            Console.WriteLine("\nPendu vous avez perdu!!!!");
        }
        


    }
} // traitement du jeu à partir du player 2
    static void AffichageDuTableau(char[] _tableWordToFind)
    {
        foreach (int i in _tableWordToFind)
        {
            Console.Write((char)i);
        }
        Console.WriteLine();
    } // faire un saut de ligne

static bool areEquals(char[] arg1, char[] arg2)
{
    if (arg1.Length != arg2.Length)
        return false;
    //
    int i=1;
    bool rt = true;
    while (i < arg1.Length-1 && rt )
    {
        if (arg1[i] != arg2[i])
            rt = false;
        i++;
    }
    return rt;
}// compare un tableau de char entre  l'indice 1 et length -2 (avant dernier) du tableau