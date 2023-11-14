using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace _13._11._2023
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Customer> customers { get; set; }
        public ApplicationContext(string connect) : base(CreatOPTIONS(connect))
        {
           // Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }

        private static DbContextOptions<ApplicationContext> CreatOPTIONS(string nameConnect)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("connect.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString(nameConnect);

            var optionBilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionBilder.UseSqlServer(connectionString).Options;

            return options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(b => b.FirstName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(b => b.LastName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(b => b.Phone).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(b => b.Email).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(b => b.Age).HasDefaultValue(15);
        }
    }



}
