using Microsoft.EntityFrameworkCore;
using UTBAirlines.Domain.Entities;

namespace UTBAirlines.Infrastructure.Database
{
    public class LetenkaDbContext : DbContext
    {
        public DbSet<Letenka> Letenky { get; set; }

        public LetenkaDbContext(DbContextOptions<LetenkaDbContext> options) : base(options)
        {
        }
    }
}