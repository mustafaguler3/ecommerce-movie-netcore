using System;
using System.Linq.Expressions;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccess.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly VtContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(VtContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();

            _context.Products.Include(x => x.Category).Include(i => i.CategoryId);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = _dbSet;
            query = query.Where(filter);
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var include in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(include);
                }
            }
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(string? includeProperties = null)
        {
            IQueryable<T> query = _dbSet;
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var include in includeProperties.Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(include);
                }
            }
            return query.ToList();
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }
    }
}

