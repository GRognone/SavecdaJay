// See https://aka.ms/new-console-template for more information

/*
L'ordinateur « choisit » aléatoirement un nombre mystère (entier compris entre 0 et 100). Le joueur essaie de le deviner. 
Lors de chaque essai, l'ordinateur affiche la « fourchette » dans laquelle se trouve le nombre qu'il a choisi. 
Le choix du nombre mystère sera simulé par génération d'un nombre aléatoire : N <-- RANDOM(0,100).
Lorsque l'utilisateur a trouvé le nombre mystère, le programme affiche "Bravo vous avez trouvé en X essais"
 */

Console.WriteLine("Hello, World!");

int userInput;
int N;
int numberOfTrials = 0;

Random rnd = new Random();
