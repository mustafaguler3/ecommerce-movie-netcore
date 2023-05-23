using System;
using System.Linq.Expressions;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Data;
using ECommerce.Entity.Entity;

namespace ECommerce.DataAccess.Concrete
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly VtContext _context;

        public CategoryRepository(VtContext context) : base(context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.Categories.Update(category);
        }
    }
}

