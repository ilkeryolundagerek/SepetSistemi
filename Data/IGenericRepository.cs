using System;
using System.Linq;
using System.Linq.Expressions;

namespace SepetSistemi.Data
{
    public interface IGenericRepository<T> where T : class
    {
        void Create(T entity);
        IQueryable<T> Read(Expression<Func<T, bool>> expression = null);
        T Read(object entityKey);
        void Update(T entity);
        void Delete(T entity);
        void Delete(object entityKey);
        void Save();
    }
}
