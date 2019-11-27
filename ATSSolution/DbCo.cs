using ATSSolution;
using ATSSolution.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ATSSolution
{
    public class DbCo : DbContext
    {
        public DbCo(DbContextOptions<DbContext> options) : base(options)
        {

        }
        DbSet<Client> Clients { get; set; }
        DbSet<Vehicle> Vehicles { get; set; }
        DbSet<Mechanic> Mechanics { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Order_Product> Order_Products { get; set; }
        DbSet<Order_Service> Order_Service { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Service> Services { get; set; }
        DbSet<User> Users { get; set; }

    }
}
