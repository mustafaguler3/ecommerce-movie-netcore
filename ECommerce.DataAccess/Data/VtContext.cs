using System;
using ECommerce.Entity.Entity;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccess.Data
{
	public class VtContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

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

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                   Id = 1,
                   Title = "Fortune o f Time",
                   Author = "Billy Spark",
                   Description = "Preasent vieta sodales libero",
                   ISBN = "SWD9999",
                   ListPrice = 99,
                   Price = 90,
                   Price50 = 85,
                   Price100 = 80,
                   CategoryId = 1,
                   ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Fortune two",
                    Author = "Billy Spark 2",
                    Description = "Preasent vieta sodales libero",
                    ISBN = "SWD9999",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 2,
                    ImageUrl = ""
                }
                );
        }
    }
}

