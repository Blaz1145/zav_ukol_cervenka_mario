using Microsoft.EntityFrameworkCore;
using UTBAirlines.Domain.Entities;
using UTBAirlines.Infrastructure.Database.Seeding;

namespace UTBAirlines.Infrastructure.Database
{
    public class LetenkaDbContext : DbContext
    {
        public DbSet<Letenka> Letenky { get; set; }

        public LetenkaDbContext(DbContextOptions<LetenkaDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var letenkaInit = new LetenkaInit();
            var letenky = letenkaInit.GetLetenky();
            modelBuilder.Entity<Letenka>().HasData(letenky);
        }
    }
}