using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BiblioControles
{
    public class ControlesAEffectuer

    {
        public static bool NomAVerifier(string nom_text)
        {
            return Regex.Match(nom_text, @"^[a-zA-Z]{0,30}$").Success;
        }

        public static bool DateAVerifier(string date_text)
        {
            DateTime resultat;
            if (DateTime.TryParse(date_text, out resultat) && resultat > DateTime.Today)
            {
                return true;
            }
            return false;
        }

        public static bool MontantAVerifier(string montant_text)
        {
            return Regex.Match(montant_text, @"^[0-9]{0,10}[\,]{0,1}[\.]{0,1}[0-9]{0,2}$").Success;
        }

        public static bool CodePostalAVerifier (string code_postal_text)
        {
            return Regex.Match(code_postal_text, @"^[0-9]{5}$").Success;
        }
     
    }
}

