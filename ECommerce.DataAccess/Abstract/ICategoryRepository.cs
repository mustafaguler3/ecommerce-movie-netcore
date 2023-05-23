using System;
using ECommerce.Entity.Entity;

namespace ECommerce.DataAccess.Abstract
{
	public interface ICategoryRepository : IRepository<Category>
	{
		void Update(Category category);
		void Save();
	}
}

