using UTBAirlines.Domain.Entities;

namespace UTBAirlines.Infrastructure.Database.Seeding
{
    internal class LetenkaInit
    {
        public IList<Letenka> GetLetenky()
        {
            IList<Letenka> letenky = new List<Letenka>();

            letenky.Add(new Letenka { Id = 1, Destinace = "Praha", Cena = 1500 });
            letenky.Add(new Letenka { Id = 2, Destinace = "Londýn", Cena = 3200 });
            letenky.Add(new Letenka { Id = 3, Destinace = "New York", Cena = 15000 });

            return letenky;
        }
    }
}