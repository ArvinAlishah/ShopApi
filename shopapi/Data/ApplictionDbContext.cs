using Microsoft.EntityFrameworkCore;
using shopapi.Entitie;

namespace shopapi.Data
{
    public class ApplictionDbContext : DbContext 
    {
        public ApplictionDbContext(DbContextOptions<ApplictionDbContext> options) : base (options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategorys { get; set; }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<ProuductImage> ProuductImages { get; set; }





    }
}
