using ApiBankTransactionModels;
using Microsoft.EntityFrameworkCore;

namespace ApiBankTransactionDbContext
{
    public class BankTransactionDbContext : DbContext
    {
        public DbSet<BankTransaction> BankTransactions { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb ;Database=tp_banks");
        }
    }
}