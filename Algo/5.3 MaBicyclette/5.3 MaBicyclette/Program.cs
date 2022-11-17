/*
 Réalisez l’algorithme et le programme correspondant au texte ci-dessous : 
S'il fait beau demain, j'irai faire une balade à bicyclette. Je n'ai pas utilisé ma bicyclette depuis plusieurs mois, peut-être n'estelle plus en parfait état de fonctionnement.
Si c'est le cas, je passerai chez le garagiste avant la balade. J'espère que les réparations seront immédiates sinon je devrai renoncer 
à la balade en bicyclette. Comme je veux de toute façon profiter du beau temps, si mon vélo n'est pas utilisable, j'irai à pied jusqu'à 
l'étang pour cueillir les joncs.
S'il ne fait pas beau, je consacrerai ma journée à la lecture. J'aimerais relire le 1er tome de Game of Thrones. Je pense posséder ce 
livre, il doit être dans la bibliothèque du salon. Si je ne le retrouve pas, j'irai l’emprunter à la bibliothèque municipale. Si le livre
n'est pas disponible, j'emprunterai un roman policier. Je rentrerai ensuite directement à la maison.
Dès que j'aurai le livre qui me convient, je m'installerai confortablement dans un fauteuil et je me plongerai dans la lecture.
*/


Console.WriteLine("S'il fait beau demain, j'irai faire une balade à bicyclette.");
if (Answers("Fera t'il beau demain?"))
{

    Console.WriteLine("Je n'ai pas utilisé ma bicyclette depuis plusieurs mois,peut être n'est-elle plus en parfait état de fonctionnement.Si c'est le cas,je passerai chez le garagiste avant la balade.");
    if (Answers("Ma bicyclette est elle en bon état ?"))
    {
        Console.WriteLine("J'irais donc faire de la bicyclette !!!");
    }
    else
    {
        Console.WriteLine("Je dois aller voir le garagiste pour voir si ma bicyclette est réparable rapidement.");
        if (Answers("Mon vélo est-il reparable rapidement ?"))
        {
            Console.WriteLine("J'irais donc faire de la bicyclette !!!");
        }
        else
        {
            Console.WriteLine("Comme je veux de toute façon profiter du beau temps,si mon vélo n'est pas utilisable, j'irai à pied jusqu'à l'étang pour cueillir les joncs.");
        }
    }
}
else
{
    Console.WriteLine("Il ne fera pas beau,je consacrerai ma journée à la lecture. J'aimerais relire le 1er tome de Game of Thrones. Je pense posséder ce livre, il doit être dans la bibliothèque du salon.");
    if (Answers("Le livres est-il dans la bibliothèque du salon?"))
    {
        Console.WriteLine("Je m'installerai confortablement dans un fauteuil et je me plongerai dans la lecture.");
    }
    else
    {
        Console.WriteLine("Je ne le retrouve pas, j'irai l’emprunter à la bibliothèque municipale. Si le livre n'est pas disponible, j'emprunterai un roman policier.");
        if (Answers("Le livre est-il disponible à la bibliothèque municipale?"))
        {
            Console.WriteLine("Je rentrerai ensuite directement à la maison. Je m'installerai confortablement dans un fauteuil et je me plongerai dans la lecture.");
        }
        else
        {
            Console.WriteLine("le livre n'est pas disponible, j'emprunterai un roman policier. Je rentrerai ensuite directement à la maison. Dès que j'aurai le livre qui me convient, je m'installerai confortablement dans un fauteuil et je me plongerai dans la lecture.");
        }
    }
}

static bool Answers(string _question) // fonction pour gerer que la reponse ne peut être que oui ou non 
{
    string temp;
    do
    {
        Console.WriteLine($"{_question} oui / non");
        temp = Console.ReadLine().ToLower();
    }
    while (temp != "oui" && temp != "non");
    if (temp == "oui")
    {
        return true;
    }
    else
    {
        return false;
    }
}