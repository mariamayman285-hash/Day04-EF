using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day04_EF.Models;
using Microsoft.EntityFrameworkCore;  //first install Microsoft.EntityFrameworkCore.SqlServer 

namespace Day04_EF.DbContexts
{
    internal class E_commerceDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=E_Commerce;Trusted_Connection=True;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }  
        public DbSet<OrderDetail> OrderDetails { get; set; } //the only one that matters here



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                        .HasKey(OD => new { OD.OrderId, OD.ProductId });

        }
    }
}
