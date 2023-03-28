using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary_Controles
{
    public static class Controles
    {
        public static bool Controle_Saisie_Nom(string nom_text)
        {
            return Regex.Match(nom_text,@"^[a-zA-Z]{0,15}[-]{0,1}[a-zA-Z]{0,15}$").Success;
        }
        public static bool Controle_Saisie_Capital_Emptrunt(string capital_emprunt_text)
        {
            return Regex.Match(capital_emprunt_text,@"^[0-9]{1,10}$").Success;
        }
    }
}
