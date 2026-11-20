using System.Linq.Expressions;

namespace UTBAirlines.Domain.Repositories
{
    public interface IRepository<T, TKey>
    {
        T? GetById(TKey id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
    }
}