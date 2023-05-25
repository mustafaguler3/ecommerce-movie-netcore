using System;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Data;
using ECommerce.Entity.Entity;

namespace ECommerce.DataAccess.Concrete
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly VtContext _context;

        public ProductRepository(VtContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Product product)
        {
            var objFromDb = _context.Products.FirstOrDefault(p => p.Id == product.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = product.Title;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Price = product.Price;
                objFromDb.Price50 = product.Price50;
                objFromDb.Price100 = product.Price100;
                objFromDb.Description = product.Description;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.Author = product.Author;
                if (product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }
            }
        }
    }
}

