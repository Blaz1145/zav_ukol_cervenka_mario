using UTBAirlines.Application.Abstraction;
using UTBAirlines.Domain.Entities;
using UTBAirlines.Domain.Repositories;

namespace UTBAirlines.Application.Implementation
{
    public class LetenkaAppService : ILetenkaAppService
    {
        private readonly ILetenkaRepository _letenkaRepository;

        public LetenkaAppService(ILetenkaRepository letenkaRepository)
        {
            _letenkaRepository = letenkaRepository;
        }

        public IList<Letenka> SelectAll()
        {
            return _letenkaRepository.GetAll().ToList();
        }
    }
}