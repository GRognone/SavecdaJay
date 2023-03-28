using ClassEmprunt;
using static ClassEmprunt.Emprunt;

namespace ConsoleTestCalculMensualite
{

    public class Program
    {

        static void Main(string[] args)
        {
            Emprunt monEmprunt;
            //remplir juste les données de la parenthèse du constucteur (ligne44 de la classe)
            monEmprunt = new Emprunt("Rognone",150000,120, EnumPeriodicite.Trimestriel,0.08f);

            double rbs = monEmprunt.Calcul_Remboursement();
            monEmprunt.Calcul_taux_Annuel_Periodicite();
            monEmprunt.Calcul_Nombre_Mensualite();


 
            Console.WriteLine(Math.Round(monEmprunt.Calcul_taux_Annuel_Periodicite(),2) + "\n" + monEmprunt.Calcul_Nombre_Mensualite() +"\n"+ Math.Round(rbs,2));


        }
    }
}