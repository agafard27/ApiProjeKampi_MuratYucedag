using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

namespace ApiProjeKampi.WebApi.Context
{
    public class ApiContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AGAFARD;initial catalog=ApiYummyDb;integrated security=true;TrustServerCertificate=True;");
        }

        public DbSet<Entities.Category> Categories { get; set; }
        public DbSet<Entities.Product> Products { get; set; }
        public DbSet<Entities.Chef> Chefs { get; set; }
        public DbSet<Entities.Contact> Contacts { get; set; }
        public DbSet<Entities.Feature> Features { get; set; }
        public DbSet<Entities.Image> Images { get; set; }
        public DbSet<Entities.Message>Message { get; set; }
        
        public DbSet<Entities.Reservation> Reservations { get; set; }
        public DbSet<Entities.Service>Services { get; set; }
        public DbSet<Entities.Testimonial> Testimonials { get; set; }
    }
    

 }

