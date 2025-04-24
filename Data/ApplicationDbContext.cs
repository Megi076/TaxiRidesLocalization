using Microsoft.EntityFrameworkCore;
using TaxiRidesLocalization.Models;

namespace TaxiRidesLocalization.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<TaxiRide> TaxiRides2 => Set<TaxiRide>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Означуваме TaxiRide како keyless ентитет, бидејќи го користиме само за читање
            modelBuilder.Entity<TaxiRide>().HasNoKey();
        }
    }
}
