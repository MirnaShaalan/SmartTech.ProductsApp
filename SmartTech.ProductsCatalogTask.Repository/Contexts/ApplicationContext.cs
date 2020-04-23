using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SmartTech.ProductsCatalogTask.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartTech.ProductsCatalogTask.Repository.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>().HasData(
        //   new Product { Id = 1, Name = "Test Product 1", LastUpdated = DateTime.Now },
        //   new Product { Id = 2, Name = "Test Product 2", LastUpdated = DateTime.Now },
        //   new Product { Id = 3, Name = "Test Product 3", LastUpdated = DateTime.Now },
        //   new Product { Id = 4, Name = "Test Product 4", LastUpdated = DateTime.Now }
        //   );
        //}



    }


}
