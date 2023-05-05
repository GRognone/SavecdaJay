using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiUser.Models
{
    [Table("Users")] // sert à nommer la table.
    public class User : Model
    {
        //[Column("user_name")] pour renommer une colonne
        [Required(ErrorMessage = " Erreur de saisie")]
        [MaxLength(16, ErrorMessage = "Erreur de saisie")]
        [StringLength(16)]
        public string? UserName { get ; set ; }
       
        public string? Password { get ; set ; }
    }
}