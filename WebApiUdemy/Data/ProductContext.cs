using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiUdemy.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                new() {Id=1,Name="Elektronik"},
                new() {Id=2,Name="OEM"}
            });
            modelBuilder.Entity<Product>().Property(X => X.Perice).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new(){Id=1,Name="Bilgisayar",CreateDate=DateTime.Now.AddDays(-3),Perice=15500,Stock=300,CategoryId=1},
                new(){Id=2,Name="Monitör",CreateDate=DateTime.Now.AddDays(-30),Perice=2899,Stock=100,CategoryId=1},
                new(){Id=3,Name="Klavye",CreateDate=DateTime.Now.AddDays(-60),Perice=158,Stock=52,CategoryId=1}
            });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
