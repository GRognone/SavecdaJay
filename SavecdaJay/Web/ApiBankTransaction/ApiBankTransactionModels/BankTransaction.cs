using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBankTransactionModels
{
    [Table("Transaction")]
    public class BankTransaction : Model
    {
        [Required]
        [Column("Transaction Date")]
        public DateTime Date { get; set; }

        [Required]
        [Column ("Transaction From")]
        [MaxLength(11, ErrorMessage = "Entrez un numero de compte à 11 chiffres")]
        [RegularExpression(@"^[0-9]{11}$")]
        public long TransactionFrom { get; set; }

        [Required]
        [Column ("Transaction To")]
        [MaxLength(11, ErrorMessage = "Entrez un numero de compte à 11 chiffres")]
        [RegularExpression(@"^[0-9]{11}$")]        
        public long TransactionTo { get; set; }

        [Required]
        [Column("Transaction Amount")]
        [RegularExpression(@"^[0-9]+(?:\.\,[0-9]{2})?$")]        
        public double TransactionAmount { get; set; }

      

    }
} 