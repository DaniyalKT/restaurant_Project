using Microsoft.EntityFrameworkCore;
using Mongo.Services.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Mongo.Services.Identity.DbContexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
