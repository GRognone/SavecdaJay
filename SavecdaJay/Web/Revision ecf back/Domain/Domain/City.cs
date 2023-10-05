using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class City
    {
        [Key]
        [Column("city_id")]
        public int Id {  get; set; }

        [Required]
        [Column("city_name")]
        public string Name { get; set; }

        [Required]
        [Column("country_code")]
        public string Code { get; set; }

        [Required]
        [Column("country_name")]
        public string Countrycode { get; set; }

    }
}