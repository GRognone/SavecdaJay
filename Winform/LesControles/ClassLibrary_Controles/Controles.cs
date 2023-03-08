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

        public static bool Controle_saisie_date(string date_text)
        {
            System.Text.RegularExpressions.Regex valide_date = new Regex(@"^([0-9]{0,2})$");
            return valide_date.IsMatch(date_text);
        }


        public static bool Controle_Saisie_Montant(string montant_text)
        {
            System.Text.RegularExpressions.Regex valide_Saisie_Montant = new Regex(@"^([0-9]{0,12})([\,]{1})+([0-9]{0,2}$)");
            return valide_Saisie_Montant.IsMatch(montant_text);
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
