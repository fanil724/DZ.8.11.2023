using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace _13._11._2023
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Customer> customers { get; set; }
        public ApplicationContext(string connect) : base(CreatOPTIONS(connect))
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Trace);
            //optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Debug);
            //optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
            //optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Warning);
            //optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Error);
            //optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Critical);
            //optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.None);


            //optionsBuilder.LogTo(Console.WriteLine, new[] { SqliteEventId.PrimaryKeyFound });
            //optionsBuilder.LogTo(Console.WriteLine, new[] { CoreEventId.QueryCompilationStarting });
            //optionsBuilder.LogTo(Console.WriteLine, new[] { RelationalEventId.CommandExecuted });


            //optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Model.Name });
            //optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Query.Name });
            //optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Infrastructure.Name });
            //optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Scaffolding.Name });
            //optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Update.Name });
            //optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Migrations.Name });

            //optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name });
            //optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Connection.Name });
            //optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Transaction.Name });


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
