using System;
using ECommerce.Entity.Entity;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccess.Data
{
	public class VtContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }

		public VtContext(DbContextOptions<VtContext> options):base(options)
		{

		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Category>().HasData(
				new Category { Id=1, Name="Action", DisplayOrder=1},
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }

                );
        }
    }
}

