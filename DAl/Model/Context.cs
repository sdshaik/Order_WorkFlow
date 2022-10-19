using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAl.Model;
using System.Security.Cryptography.X509Certificates;

namespace DAl.Model
{
   public class Context :DbContext
    {
        public Context(DbContextOptions options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(new Order
            {
                Order_id = 1,
                Order_date = new DateTime(2019, 02, 12),
                Order_Status = "Active",
                Product_Id = 1,
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                User_Id = 1,
                User_Name="ABC",
                Order_Id = 1,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Product_Id = 1,
                Product_Price = 100.1,
                Product_stock_qun = "10"

            });
        }
    }
}
