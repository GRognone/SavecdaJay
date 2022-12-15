namespace Voiture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Roue roueParDefaut = new Roue();
            Roue maRoue= new Roue(roueParDefaut);

            bool retour1 = roueParDefaut.Stopper();//false
            bool retour2 = roueParDefaut.Tourner();//true
            bool retour3 = roueParDefaut.Tourner();//false
            bool retour4 = roueParDefaut.Stopper();//true

            Moteur moteur_parDefaut = new Moteur();
            Roue roue1 = new Roue();
            Roue roue2 = new Roue();

            bool retour5 = moteur_parDefaut.Eteindre();//false
            bool retour6 = moteur_parDefaut.EntrainerRoue(maRoue, maRoue);//false
            bool retour7 = moteur_parDefaut.ArreterRoues(maRoue, maRoue);//false
            bool retour8 = moteur_parDefaut.Demarrer();//true
            bool retour9 = moteur_parDefaut.Demarrer();//false
            bool retour10 = moteur_parDefaut.ArreterRoues(maRoue, maRoue);//false
            bool retour11 = moteur_parDefaut.EntrainerRoue(maRoue, maRoue);//true
            bool retour12 = moteur_parDefaut.EntrainerRoue(maRoue, maRoue);//false
            bool retour13 = moteur_parDefaut.ArreterRoues(maRoue, maRoue);//true
            bool retour14 = moteur_parDefaut.Eteindre();//true
           


            Voiture voiture_parDefaut = new Voiture();
            Voiture mavoiture = new Voiture(voiture_parDefaut);

            bool retour15 = voiture_parDefaut.Demarrer(); //true
            bool retour16 = voiture_parDefaut.Avancer(); //true
            bool retour17= voiture_parDefaut.Avancer();//false
            bool retour18 = voiture_parDefaut.CouperContact();//false
            bool retour19 = voiture_parDefaut.Freiner();//true
            bool retour20 = voiture_parDefaut.Freiner();//false
            bool retour21 = voiture_parDefaut.CouperContact();//true
            bool retour22 = voiture_parDefaut.CouperContact();//false
            bool retour23 = voiture_parDefaut.Freiner();//false
            bool retour24 = voiture_parDefaut.Avancer();//false



            int nc = 0;
        }
    }
}