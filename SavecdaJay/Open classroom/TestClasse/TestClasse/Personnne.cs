using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasse
{
    public class Personne
    {
        private string nom;
        private string prenom;
        public int age { get; set; } // soit on applique {get;set;}et age devient une propriete, soit solution 2 mettre age en prive
        public Personne(string unNom, string unPrenom, int UnAge)
        {
            nom = unNom;
            prenom = unPrenom;
            age = UnAge;
        }
        //solution 2
        /*  public string GetAge()
           {
               return age.ToString();
           }
           public void SetAge(int value)
           { x
               age = value;
           }*/
        public string Info()
        {
            return nom + " " + prenom + " " + age + " ans";
        }
    }
}
