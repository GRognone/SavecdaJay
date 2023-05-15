using BankTransactions.Models;
using Microsoft.EntityFrameworkCore;

namespace BankTransactions.DataBase
{
    public class BankDbContext : DbContext
    {
        public DbSet<BankTransaction>Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=tp_banks");
        }
    }
}