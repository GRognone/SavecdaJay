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
            Moteur monMoteur = new Moteur(moteur_parDefaut);

            bool retour5 = moteur_parDefaut.Demarrer();//true
            bool retour6 = moteur_parDefaut.Eteindre();//false
            bool retour7 = moteur_parDefaut.EntrainerRoue(maRoue,maRoue);//true
            bool retour8 = moteur_parDefaut.ArreterRoues(maRoue, maRoue);//false
            bool retour9 = moteur_parDefaut.ArreterRoues(maRoue, maRoue);//true
            bool retour10 = moteur_parDefaut.EntrainerRoue(maRoue, maRoue);//false
            bool retour11 = moteur_parDefaut.Eteindre();//true
            bool retour12 = moteur_parDefaut.Demarrer();//false


            Voiture voiture_parDefaut = new Voiture();
            Voiture voiturevoiture = new Voiture(voiture_parDefaut);

            bool retour13 = voiture_parDefaut.Demarrer(); //true
            bool retour14 = voiture_parDefaut.Avancer(); //true
            bool retour15= voiture_parDefaut.Avancer();//false
            bool retour16 = voiture_parDefaut.CouperContact();//false
            bool retour17 = voiture_parDefaut.Freiner();//true
            bool retour18 = voiture_parDefaut.Freiner();//false
            bool retour19 = voiture_parDefaut.CouperContact();//true
            bool retour20 = voiture_parDefaut.Demarrer();//false
           


          int nc = 0;
        }
    }
}