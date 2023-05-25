using System;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concrete;
using ECommerce.DataAccess.Data;

namespace ECommerce.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICategoryRepository CategoryRepository { get; private set; }

        public IProductRepository ProductRepository { get; private set; }

        private readonly VtContext _context;

        public UnitOfWork(VtContext context)
        {
            _context = context;
            ProductRepository = new ProductRepository(context);
            CategoryRepository = new CategoryRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

