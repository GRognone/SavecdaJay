using Domain;
using Microsoft.EntityFrameworkCore;

namespace Bdd
{
    public class BddContext : DbContext
    {
        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string str = @"Server=(localdb)\mssqllocaldb ;Database=db_test";
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(str);

        }

        // POUR API FLUENT SURCHARGER OnModelCreating

    }
}