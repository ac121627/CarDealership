using CarDealership.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.Data
{
    public class DbContextCarDealer:DbContext
    {
     
        public DbContextCarDealer(DbContextOptions<DbContextCarDealer> options) : base(options)
        { 
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
         
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Car)         
                .WithOne(c => c.Order)     
                .HasForeignKey<Car>(c => c.OrderID); 

            base.OnModelCreating(modelBuilder);
        }
    }
}