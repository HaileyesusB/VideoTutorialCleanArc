
using Core.Entities;
using Infrastructure.Data.Config;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Data

{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base
            (options)
        { 
        }
        public DbSet<Products> Products { get; set; }
        
        public DbSet<ProductBrand> ProductBrand { get; set;}

        public DbSet<ProductType> ProductType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}