using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary_Controles
{
    public static class Controles
    {



       public static bool Controle_saisie_nom(string nom_text)
        {
            System.Text.RegularExpressions.Regex valide_nom = new Regex(@"^[a-zA-Z]{0,30}$");
            return valide_nom.IsMatch(nom_text);
        }
        /* 
        public void Controle_saisie_date()
        {

        }
        */

        public void Controle_Saisie_Montant()
        {
            System.Text.RegularExpressions.Regex valide_Saisie_Montant = new Regex (@"^$")
        }
     
        public static bool Controle_Saisie_Code_Postal(string code_postal_text)
        {
            if (code_postal_text.Length == 5)
            {
                System.Text.RegularExpressions.Regex valid_code_postal = new Regex(@"^[0-9]{5}$");
                return valid_code_postal.IsMatch(code_postal_text);
            }
            return false;
        }
    }
}