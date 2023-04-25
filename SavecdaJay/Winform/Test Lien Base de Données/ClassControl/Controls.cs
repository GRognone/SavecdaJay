using System.Data;
using System.Text.RegularExpressions;

namespace ClassControl
{
    public class Controls
    {
        public static bool saisieAControler(string userInput)
        {
            return Regex.Match(userInput, @"^[a-zA-Z]{1,50}[-]{0,1}[a-zA-Z]{0,50}$").Success;
        }

        public static bool sasieCodePaysAControler(string userInput)
        {
            return Regex.Match(userInput, @"^([a-zA-Z]{2})$").Success;
        }
    }
}