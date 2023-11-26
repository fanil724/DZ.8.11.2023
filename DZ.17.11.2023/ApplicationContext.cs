using Microsoft.EntityFrameworkCore;

namespace DZ._17._11._2023
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Firma> firma { get; set; } = null!;
        public DbSet<Human> humans { get; set; } = null!;
        public DbSet<Department> departments { get; set; } = null!;


        public ApplicationContext()
        {
           // Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Firma.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Human>().HasIndex(h=>new {h.Surname, h.Name });
            modelBuilder.Entity<Department>().HasIndex(d => d.Name).HasFilter("[Name] IS NOT NULL");
        }

    }
}
