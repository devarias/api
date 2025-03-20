using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<City> City { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().ToTable("city").HasKey(u => u.Id);

            modelBuilder.Entity<City>()
        .Property(u => u.Id).HasColumnName("id");

            modelBuilder.Entity<City>()
                .Property(u => u.Description).HasColumnName("description");
        }
    }
}