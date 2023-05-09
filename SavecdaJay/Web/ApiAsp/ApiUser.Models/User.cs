using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiUser.Models
{
    [Table("Users")] // sert à nommer la table.
    public class User : Model
    {
        //[Column("user_name")] pour renommer une colonne
        [Required(ErrorMessage = "Le nom d'utilisateur est requis")]
        [MaxLength(16, ErrorMessage = "Erreur de saisie")]
        [StringLength(16, ErrorMessage = "Veuillez saisir 16 caractères")]
        [RegularExpression(@"^[a-zA-Z]+(?:\-[a-zA-Z]+)?$")]
        public string? UserName { get ; set ; }

        [Required(ErrorMessage = "Le mot de passe est obligatoire")]
        [RegularExpression(@"^[a-zA-Z0-9]{8,}$")] //{8,} veut dire 8 caractères minimum.
        public string? Password { get ; set ; }

        public string passwordToCheck()
        {
            throw new NotImplementedException();
        }
    }
}