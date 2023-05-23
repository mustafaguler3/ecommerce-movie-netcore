using System;
using System.Linq.Expressions;

namespace ECommerce.DataAccess.Abstract
{
	public interface IRepository<T> where T : class
	{
		IEnumerable<T> GetAll();
		T Get(Expression<Func<T, bool>> filter);
		void Add(T entity);
		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entities);
	}
}

