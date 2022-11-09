// See https://aka.ms/new-console-template for more information

/*
L'ordinateur « choisit » aléatoirement un nombre mystère (entier compris entre 0 et 100). Le joueur essaie de le deviner. 
Lors de chaque essai, l'ordinateur affiche la « fourchette » dans laquelle se trouve le nombre qu'il a choisi. 
Le choix du nombre mystère sera simulé par génération d'un nombre aléatoire : N <-- RANDOM(0,100).
Lorsque l'utilisateur a trouvé le nombre mystère, le programme affiche "Bravo vous avez trouvé en X essais"
 */

Random rnd = new Random();
int userInput;
int computerRandom = rnd.Next(101);
int forkMin = 0;
int forkMax = 100;
int numberOfTrials = 1;
bool found = false;

Console.WriteLine("Bonjour, jouons à trouver un numero choisi par l'ordinateur entre 1 et 100, chaque essais sera comptabilisé et la fourchette sera indiqué entre chaques essais bonne chance !!!");

do
{

    do
    {
        Console.WriteLine("Essayez de trouver le nombre de l'ordinateur entre " + forkMin + " et " + forkMax, " bonne chance!");
        userInput = int.Parse(Console.ReadLine());
    }

    while (userInput < forkMin || userInput > forkMax);

    if (userInput < computerRandom)
    {
        forkMin = userInput;
        numberOfTrials++;
    }
    else if (userInput > computerRandom)
    {
        forkMax = userInput;
        numberOfTrials++;
    }


    else
    {
        Console.WriteLine("Bravo vous avez trouve le bon numero c'etait " + userInput + " en " + numberOfTrials + " essais");
        found = true;
    }

}
while

(!found);
Console.WriteLine("Partie terminé");
Console.ReadLine();