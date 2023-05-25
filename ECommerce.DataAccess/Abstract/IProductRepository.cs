using System;
using ECommerce.Entity.Entity;

namespace ECommerce.DataAccess.Abstract
{
	public interface IProductRepository : IRepository<Product>
	{
		void Update(Product product);
	}
}

