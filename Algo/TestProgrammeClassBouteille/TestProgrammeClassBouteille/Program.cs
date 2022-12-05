namespace TestProgrammeClassBouteille
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Declaration 

            Bouteille bouteilleDeChampagne;
            //Bouteille bouteilleDEau;
            //Bouteille bouteilleDeChampagneCopie;

            bouteilleDeChampagne = new Bouteille();

            //bouteilleDeChampagneCopie = new Bouteille(bouteilleDeChampagne);

            //bouteilleDEau = new Bouteille(150, 150, false);

          
          
            int a = 2;

            bool resultat = bouteilleDeChampagne.Ouvrir();
            bool resultat2 = bouteilleDeChampagne.Ouvrir();

            bool resultat3 = bouteilleDeChampagne.Remplir();

            //bool resultat2 = bouteilleDeChampagne.Fermer();

            //bool resultat3 = bouteilleDEau.Ouvrir();
            //bool resultat4 = bouteilleDEau.Fermer();


            



        }
    }
}