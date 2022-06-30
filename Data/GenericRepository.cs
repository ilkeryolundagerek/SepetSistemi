using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SepetSistemi.Data
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected DbContext _context;
        protected DbSet<T> _set;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _set = context.Set<T>();
        }

        public void Create(T entity)
        {
            _set.Add(entity);
        }

        public void Delete(T entity)
        {
            _set.Remove(entity);
        }

        public void Delete(object entityKey)
        {
            Delete(Read(entityKey));
        }

        public IQueryable<T> Read(Expression<Func<T, bool>> expression = null)
        {
            if (expression == null)
            {
                return _set;
            }
            else
            {
                return _set.Where(expression);
            }
        }

        public T Read(object entityKey)
        {
            return _set.Find(entityKey);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _set.Update(entity);
        }
    }
}
