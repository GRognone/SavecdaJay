using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryControle
{
    public class Controles
    {
        public static bool NomAVerifier(string nom_text)
        {
            return Regex.Match(nom_text, @"^[a-z]{0-30}[-]{0,1}[A-Z]{0,30}$").Success;
        }

        public static bool IndexElementAVerifier(string index_text)
        {
            return Regex.Match(index_text, @"[0-9]^$").Success;
        }
    }
}
