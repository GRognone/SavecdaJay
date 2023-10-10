namespace Barnabe
{
    public class Program
    {
        static void Main(string[] args)
        {

            decimal S;
            
            Console.WriteLine("Barnabe dispose d'une somme choisie par l'utilisateur nous allons déterminer dans combien de magasins il peut dépenser sachant que dans chacuns des magasins il dépense 1€ de plus que la moitié de la somme restante.");

            Console.WriteLine("Veuillez-saisir un montant de base svp.");
            S = decimal.Parse(Console.ReadLine());

            int VisitingShop = NbMagasinRealisePArBarnabe(S);
            Console.WriteLine(" Barnabé a pu depenser l'integralite de ses " + S + " euros dans " + VisitingShop + " magasins .");
        }

        public static int NbMagasinRealisePArBarnabe(decimal sommeDansLePorteMonnaieDeBarnabe)
        { 
            int VisitingShop = 0;
            do
            {
                sommeDansLePorteMonnaieDeBarnabe = (sommeDansLePorteMonnaieDeBarnabe / 2) - 1;
                VisitingShop++;
                Console.WriteLine("Le montant restant est de " + sommeDansLePorteMonnaieDeBarnabe + " suite achat magasin " + VisitingShop);
            }
            while (sommeDansLePorteMonnaieDeBarnabe >=2);
            return VisitingShop;
        }
    }








}