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
            return Regex.Match(nom_text, @"^[a-zA-Z]{0,30}$").Success;
        }

        public static bool Controle_saisie_date(string date_text)
        {
            DateTime resultat;
            if (DateTime.TryParse(date_text, out resultat))
            {
                return true;
            }
            return false;
        }

        public static bool Controle_Saisie_Montant(string montant_text)
        {
            return Regex.Match(montant_text, @"^([0-9]{0,12})([\.|\,]{0,1})+([0-9]{0,2}$)").Success;
        }

        public static bool Controle_Saisie_Code_Postal(string code_postal_text)
        {
            if (code_postal_text.Length == 5)
            {
                return Regex.Match(code_postal_text, (@"^[0-9]{5}$")).Success;
            }
            return false;
        }
    }
}
