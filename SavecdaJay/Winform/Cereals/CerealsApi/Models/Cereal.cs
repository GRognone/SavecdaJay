using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CerealsApi.Models
{
    [Table("tbl_cereals")]// pour renommer la table autrement le nom sera pris par defaut du context.
    public class Cereal : Model
    { 
        public int CerealId { get => base.Id; }

        [Required]
        //[Column("nom_de_la_colonne_en_bas_de_donnees")]
        public string Name { get; set; }

        [Required]
        public int Calories { get; set; }

        [Required]
        public int Protein { get; set; }

    

    }
}
