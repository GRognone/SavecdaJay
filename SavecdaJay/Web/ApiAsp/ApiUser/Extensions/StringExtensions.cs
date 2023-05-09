using BCrypt.Net;
namespace ApiUser.Extensions
{
    /// <summary>
    /// Classe d'extension
    /// La classe doit être statique
    /// </summary>
    public static class StringExtensions
    {
        public static string ToPassword(this string str)
        {
            return BCrypt.Net.BCrypt.HashPassword(str);
        }
        //verification que le mot de passe chiffré et non chiffrés sont compatibles.
        public static bool CheckPassword(this string passwordHash, string passwordToTest) 
        {
            return BCrypt.Net.BCrypt.Verify(passwordToTest, passwordHash);
        }
    }
}
