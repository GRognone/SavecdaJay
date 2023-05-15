using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BankTransactions.Models
{
    [Table("bank_transactions")]
    public class BankTransaction
    {
        [Key]
        [Column("transaction_id")]
        public int Transaction_Id { get; set; }

        [Required]
        [Column("transaction_Date")]
        public DateTime Transaction_Date { get; set; }

        [Required]
        [Column("transaction_from")]
        [Range (10000000000, 99999999999)]
        public long Transaction_From { get; set; }

        [Required]
        [Column("transaction_to")]
        [Range(10000000000, 99999999999)]
        public long Transaction_To{ get; set; }

        [Required]
        [Column("transaction_amount")]
        [Range(0.01, 99000)]
        public decimal Transaction_Amount { get; set; }        
    }

}