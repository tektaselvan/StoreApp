using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product() {ProductId = 1, ProductName = "Product 1", Price = 1000},
                new Product() {ProductId = 2, ProductName = "Product 2", Price = 2000},
                new Product() {ProductId = 3, ProductName = "Product 3", Price = 3000},
                new Product() {ProductId = 4, ProductName = "Product 4", Price = 4000},
                new Product() {ProductId = 5, ProductName = "Product 5", Price = 5000}
            );
        }

    }
}