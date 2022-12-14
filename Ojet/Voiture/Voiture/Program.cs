namespace Voiture
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Roue roueParDefaut = new Roue();

            bool retour1 = roueParDefaut.Stopper();//false
            bool retour2 = roueParDefaut.Tourner();//true
            bool retour3 = roueParDefaut.Tourner();//false
            bool retour4 = roueParDefaut.Stopper();//true

            Moteur moteur_parDefaut = new Moteur();
            Roue roue1 = new Roue();
            Roue roue2 = new Roue();

            bool retour5 = moteur_parDefaut.Eteindre();//false
            bool retour6 = moteur_parDefaut.EntrainerRoue();*/

           /* Voiture voiture_parDefaut = new Voiture();
            Voiture voiturevoiture = new Voiture(voiture_parDefaut);

             bool retour1 = voiture_parDefaut.Demarrer(); //true
             bool retour2 = voiture_parDefaut.Avancer(); //true
             bool retour7 = voiture_parDefaut.Avancer();//false
             bool retour3 = voiture_parDefaut.CouperContact();//false
             bool retour4 = voiture_parDefaut.Freiner();//true
             bool retour6 = voiture_parDefaut.Freiner();//false

             bool retour5 = voiture_parDefaut.CouperContact();//true

             bool retour8 = voiture_parDefaut.Freiner();//false
             bool retour9 = voiture_parDefaut*/




            Roue[] roues = new Roue[] { new Roue(), new Roue(), new Roue(), new Roue(), new Roue(), new Roue() };
            Moteur moteur = new Moteur();
            string marque = "Citroen";
            //Utilisation du constructeur V1 : public Voiture(string _marque, Moteur _sonMoteur, Roue[] _ses4roues)
            Voiture voiture = new Voiture(marque, moteur, roues);
            Roue roueA = new Roue();
            Roue roueB = new Roue();
            Roue roueC = new Roue();
            Roue roueD = new Roue();
            Moteur moteurB = new Moteur();
            //Utilisation du constructeur V2 : public Voiture(string _marque, Moteur _sonMoteur,
            //Roue _roue1, Roue _roue2, Roue _roue3, Roue _roue4)
            Voiture voitureB = new Voiture(marque, moteur, roueA, roueB, roueC, roueD);
            //Utilisation du constructeur V3 : public Voiture(string _marque, bool _enMarche,
            // bool _tourne, string _dimensionPneu)
            Voiture voitureC = new Voiture(marque, false, false, "240/15/10V");



            int nc = 0;
        }
    }
}