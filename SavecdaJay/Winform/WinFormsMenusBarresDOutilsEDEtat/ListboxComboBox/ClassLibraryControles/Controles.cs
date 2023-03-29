using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryControles
{
  public class Controles
    {
        public static bool SaisieAVerifier(string userInput)
        {
            return Regex.Match(userInput, @"^[a-zA-Z]{1,50}[-]{0,1}[a-zA-Z]{0,50}$").Success;
        }
    }
}
