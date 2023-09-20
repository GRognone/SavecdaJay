namespace TestProgrammeClassBouteille
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Declaration 

            Bouteille bouteilleDeChampagne;
            Bouteille bouteilleDEau;
            Bouteille bouteilleDeChampagneCopie;

            bouteilleDeChampagne = new Bouteille();

            bouteilleDeChampagneCopie = new Bouteille(bouteilleDeChampagne);

            bouteilleDEau = new Bouteille(150, 150, false);



            bool resultat = bouteilleDeChampagne.Ouvrir();
            bool resultat2 = bouteilleDeChampagne.Fermer();
            bool resultat3 = bouteilleDeChampagne.Vider(50);
            bool resultat4 = bouteilleDeChampagne.Vider();
            bool resultat5 = bouteilleDeChampagne.Remplir(50);
            bool resultat6 = bouteilleDeChampagne.Remplir();
        }
    }
}