using Microsoft.EntityFrameworkCore;
namespace LOLEMCosmetics.Models
{
    public class LOLEMCosmeticsDbContext : DbContext
    {
        public LOLEMCosmeticsDbContext(DbContextOptions<LOLEMCosmeticsDbContext> options)
        : base(options) { }
        public DbSet<LOLEM> LOLEMs { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
