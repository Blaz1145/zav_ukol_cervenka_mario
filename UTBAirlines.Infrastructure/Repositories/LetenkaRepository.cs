using UTBAirlines.Domain.Entities;
using UTBAirlines.Domain.Repositories;
using UTBAirlines.Infrastructure.Database;

namespace UTBAirlines.Infrastructure.Repositories
{
    public class LetenkaRepository : Repository<Letenka, int>, ILetenkaRepository
    {
        public LetenkaRepository(LetenkaDbContext dbContext) : base(dbContext)
        {
        }
    }
}