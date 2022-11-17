/*
 *A tour de rôle, l'ordinateur et le joueur choisissent un nombre qui ne peut prendre que 3 valeurs: 0, 1 ou 2. Le choix du nombre par l'ordinateur sera simulé par génération d'un nombre aléatoire : N <-- RANDOM
Si la différence entre les nombres choisi vaut :
▪ 2:lejoueur qui a proposé le plus grand nombre gagne un point. ▪ 1:le joueur qui aproposé le plus petit nombre gagne un point. ▪ 0 : aucun point n'est marqué.
Le jeu se termine quand un des deux joueurs (l'ordinateur ou le joueur humain) totalise 10 points ou quand l'être humain introduit un nombre négatif qui indique sa volonté d'arrêter de jouer.
Dans les 2 cas, afficher les scores. 
 */

Random rnd = new Random();
int computer;
int player;
int ComputerPoint = 0;
int playerPoint = 0;
bool reset = true;

Console.WriteLine("Jouons contre l'ordinateur une partie de 2-0,\nl'ordinateur et le joueur choisissent à tour de rôle un des 3 chiffres suivants 0,1 ou 2.\nSi la difference entre les 2 nombres est égale à 2 alors le joueur qui a choisi le 2 gagne 1 point, \nsi l'écart n'est que de 1 point alors c'est le joueur qui a choisi le plus petit nombre qui gagne 1 point, \nautrement aucun point n'est attribué. \nLe 1er joueur à 10 points gagne la partie.\nVous pouvez quitter la partie à tout moment en saisissant un nombre négatif, bonne chance.");
while (reset)
{
    computer = rnd.Next(3);
    Console.WriteLine("A vous de jouer Joueur 1 choisissez un nombre entre 0,1 ou 2 svp.");
    player = int.Parse(Console.ReadLine());
    if (player < 0)
    {
        reset = false;
        Console.WriteLine("au revoir");
    }
    else if (player > 2)
    {
        Console.WriteLine("Veuillez saisir un nombre correcte svp.\n");
    }
    else if ((player < computer) && ((computer - player) > 1))
    {
        ComputerPoint++;
        Console.WriteLine("L'ordinateur marque 1 point\n");
    }
    else if ((player < computer) && ((computer - player) == 1))
    {
        playerPoint++;
        Console.WriteLine("Le joueur marque 1 point\n");
    }
    else if ((player > computer) && ((player - computer) > 1))
    {
        playerPoint++;
        Console.WriteLine("Le joueur marque 1 point\n");
    }
    else if ((player > computer) && ((player - computer) == 1))
    {
        ComputerPoint++;
        Console.WriteLine("L'ordinateur marque 1 point\n");
    }
    else
     {
        Console.WriteLine("Egalite personne ne marque le point.\n");
    }
    Console.WriteLine("L'ordinateur a " + ComputerPoint + " points, le joueur a " + playerPoint + " points\n");

    if (ComputerPoint == 10)
    {
        reset = false;
        Console.WriteLine("l'ordinateur gagne, fin de partie.");
    }
    else if (playerPoint == 10)
    {
        reset = false;
        Console.WriteLine("Le joueur gagne, fin de partie.");
    }
}
Console.ReadLine();