// See https://aka.ms/new-console-template for more information

/*
 * Barnabé fait ses courses dans plusieurs magasins.
Dans chacun, il dépense 1 € de plus que la moitié de ce qu’il possédait en entrant. 
Dans le dernier magasin, il dépense le solde.
Barnabé dépense au moins 1 € dans chaque magasin.
Soit S un nombre entier représentant la somme dont il disposait au départ (S > 1 euro). 
Représenter l’algorithme permettant de trouver le nombre de magasins dans lesquels il a acheté.
*/

int S;
int Rest;
int VisitingShop = 1;

Console.WriteLine("Barnabe dispose d'une somme choisie par l'utilisateur nous allons déterminer dans combien de magasins il peut dépenser sachant que dans chacuns des magasins il dépense 1€ de plus que la moitié de la somme restante.");

Console.WriteLine("Veuillez-saisir un montant de base svp.");
S = int.Parse(Console.ReadLine());
Rest = S;

do
{
    Rest = (Rest / 2) - 1;
    VisitingShop++;
    //Console.WriteLine("Le montant restant est de " + Rest + " suite achat magasin " + VisitingShop);
}
while (Rest > 2);
Console.WriteLine(" Barnabé a pu depenser l'integralite de ses " + S + " euros dans " + VisitingShop + " magasins .");