using System;
using ECommerce.DataAccess.Abstract;

namespace ECommerce.DataAccess.UnitOfWork
{
	public interface IUnitOfWork
	{
		ICategoryRepository CategoryRepository { get; }

        IProductRepository ProductRepository { get; }

        void Save();
	}
}

