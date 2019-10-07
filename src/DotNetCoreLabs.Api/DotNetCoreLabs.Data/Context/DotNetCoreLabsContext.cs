using Microsoft.EntityFrameworkCore;
using DotNetCoreLabs.Data.Entities;
using DotNetCoreLabs.Data.Seed.Seeders;

namespace DotNetCoreLabs.Data.Context
{
    public partial class DotNetCoreLabsContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DotNetCoreLabsContext()
        {
        }

        public DotNetCoreLabsContext(DbContextOptions<DotNetCoreLabsContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new UserSeeder().UsersData());
                
        }
    }
}
