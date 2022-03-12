using Microsoft.EntityFrameworkCore;
using Mongo.Services.ProductApi.Models;

namespace Mongo.Services.ProductApi.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}
