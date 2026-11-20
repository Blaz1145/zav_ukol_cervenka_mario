using UTBAirlines.Domain.Entities;

namespace UTBAirlines.Application.Abstraction
{
    public interface ILetenkaAppService
    {
        IList<Letenka> SelectAll();
    }
}