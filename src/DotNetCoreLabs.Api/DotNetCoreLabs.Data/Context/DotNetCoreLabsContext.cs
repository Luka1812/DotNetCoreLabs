using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using System.IO;
using DotNetCoreLabs.Data.Entities;

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("App.json", optional: true, reloadOnChange: true);

                IConfigurationRoot configuration = builder.Build();
                
                optionsBuilder.UseMySQL(configuration.GetConnectionString("database"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");
        }
    }
}
