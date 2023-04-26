using System.Text.RegularExpressions;

namespace ClassLibraryControl
{
    public class Controls
    {
        public static bool VerifIdentifiantPuce(string numberOK)
        {
            return Regex.Match(numberOK, @"^25026[0-9]{10}$").Success;
        }
    }

}