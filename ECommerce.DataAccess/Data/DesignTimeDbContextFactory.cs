using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ECommerce.DataAccess.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<VtContext>
    {
        public VtContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<VtContext>();
            var connectionString = "server=localhost;database=movieApp;User Id=sa;Password=Passw0rd;TrustServerCertificate=True";
            builder.UseSqlServer(connectionString);

            return new VtContext(builder.Options);
        }
    }
}

