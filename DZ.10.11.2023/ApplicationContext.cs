using Microsoft.EntityFrameworkCore;

namespace DZ._10._11._2023
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Car> car => Set<Car>();

        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=cars.db");
        }

    }
}
