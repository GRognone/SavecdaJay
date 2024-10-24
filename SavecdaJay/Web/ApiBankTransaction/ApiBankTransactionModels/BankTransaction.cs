﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBankTransactionModels
{
    [Table("bank_transaction")]
    public class BankTransaction
    {
        [Key]
        [Column("transaction_id")]
        public int Id { get; set; }

        [Required]
        [Column("transaction_date")]
        public DateTime Transaction_Date { get; set; }

        [Required]
        [Column("transaction_from")]
        [Range(10000000000, 99999999999)]
        public long Transaction_From { get; set; }

        [Required]
        [Column("transaction_to")]
        [Range(10000000000, 99999999999)]
        public long Transaction_To { get; set; }

        [Required]
        [Column("transaction_amount")]
        [Range(0.01, 99000.0)]
        public decimal Transaction_Amount { get; set; }
    }
}