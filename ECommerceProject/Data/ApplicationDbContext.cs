using ECommerceProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ECommerceProject.Models.User> Users { get; set; } = default!;
        public DbSet<ECommerceProject.Models.Currency> Currencies { get; set; } = default!;
        public DbSet<ECommerceProject.Models.Store> Stores { get; set; } = default!;
        public DbSet<ECommerceProject.Models.Category> Categories { get; set; } = default!;
    }
}
