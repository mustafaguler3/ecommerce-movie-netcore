using System;
using ECommerce.Entity.Entity;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccess.Data
{
	public class VtContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public VtContext(DbContextOptions<VtContext> options) : base(options)
		{

		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Category>().HasData(
				new Category { Id=1, Name="Action", DisplayOrder=1},
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Horror", DisplayOrder = 3 }

                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                   Id = 1,
                   Title = "Iron Man",
                   Author = "Billy Spark",
                   Description = "Preasent vieta sodales libero",
                   ISBN = "SWD9999",
                   ListPrice = 120,
                   Price = 90,
                   Price50 = 85,
                   Price100 = 80,
                   CategoryId = 1,
                   ImageUrl = "images/product/iron-man.webp"
                },
                new Product
                {
                    Id = 2,
                    Title = "Harry Potter",
                    Author = "Jhonson K.W",
                    Description = "Preasent vieta sodales libero",
                    ISBN = "SWD9999",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 2,
                    ImageUrl = "images/product/harry.png"
                },
                new Product
                {
                    Id = 3,
                    Title = "Smile",
                    Author = "Billy Spark 2",
                    Description = "Preasent vieta sodales libero",
                    ISBN = "SWD9999",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 3,
                    ImageUrl = "images/product/smile-horror.jpg"
                },
                new Product
                {
                    Id = 4,
                    Title = "Wood",
                    Author = "Billy Spark 2",
                    Description = "Preasent vieta sodales libero",
                    ISBN = "SWD9999",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 3,
                    ImageUrl = "images/product/wood.webp"
                },
                new Product
                {
                    Id = 5,
                    Title = "Freedom",
                    Author = "Billy Spark 2",
                    Description = "Preasent vieta sodales libero",
                    ISBN = "SWD9999",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl = "images/product/wood.webp"
                }
                );
        }
    }
}

