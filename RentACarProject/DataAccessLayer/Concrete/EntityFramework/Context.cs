using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    // Veri tabanı bağlantısı bu classta kurulur. 
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-O1J0TIB\\SQLEXPRESS; Database=RentACarDB;Trusted_Connection=true");
        }
        
        public DbSet<Brand> brands { get; set; }
        public DbSet<Car> cars { get; set; }
        public DbSet<Color> colors { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<PaymentMethod> paymentMethods { get; set; }
        public DbSet<Rental> rentals { get; set; }
        
    }
}
