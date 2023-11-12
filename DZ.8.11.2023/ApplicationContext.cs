using Microsoft.EntityFrameworkCore;

namespace DZ._8._11._2023
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Faculties> faculties => Set<Faculties>();
        public DbSet<Departments> departments => Set<Departments>();
        public DbSet<Groups> groups => Set<Groups>();
        public DbSet<Curators> curators => Set<Curators>();


        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=academia.db");
        }
    }
}
