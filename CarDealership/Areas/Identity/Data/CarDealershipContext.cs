
using CarDealership.Models; // Include your models' namespace
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.Areas.Identity.Data
{
    public class CarDealershipContext : IdentityDbContext<CarDealershipUser>
    {
        public CarDealershipContext(DbContextOptions<CarDealershipContext> options)
            : base(options)
        {
        }

         
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); 


            builder.Entity<Car>()
                .HasOne(c => c.Order)
                .WithOne(o => o.Car) 
                .HasForeignKey<Car>(c => c.OrderID);

            builder.Entity<Order>()
                .HasOne(o => o.Customers)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomersId);

           
            builder.Entity<Order>()
                .HasOne(o => o.Staff)
                .WithMany(s => s.Orders)
                .HasForeignKey(o => o.StaffId);

            
            builder.Entity<Car>()
                .HasOne(c => c.Store)
                .WithMany(s => s.Cars)
                .HasForeignKey(c => c.StoreID);

       
            builder.Entity<Staff>()
                .HasOne(s => s.Store)
                .WithMany(st => st.Staff)
                .HasForeignKey(s => s.StoreID);
        }
    }
}
