using eShop_1.Models;
using Microsoft.EntityFrameworkCore;

namespace eShop_1.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder
        //        .Entity<Brand_Product>().HasKey(bp => new
        //        {
        //            bp.BrandId,
        //            bp.ProductId
        //        });
        //    modelBuilder.Entity<Brand_Product>().HasOne(b => b.Brand).WithMany(bp=>bp.Brand_Products)
        //        .HasForeignKey(b => b.BrandId);
        //    modelBuilder.Entity<Brand_Product>().HasOne(b => b.Product).WithOne(b => b.Brand_Product)
        //        .HasForeignKey<Brand_Product>(b => b.ProductId);


        //    base.OnModelCreating(modelBuilder);
        //}
        // public DbSet<Brand_Product> Brand_Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }  
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
