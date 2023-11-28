using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace DZ._27._11._23
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Student> students { get; set; } = null!;
        public DbSet<Gruops> gruops { get; set; } = null!;
        public DbSet<GroupsStudents> groupsStudents { get; set; } = null!;

        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = StudentsGroup; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property(s => s.Surname).HasMaxLength(20);
            modelBuilder.Entity<Student>().Property(s => s.Name).HasMaxLength(20);
            modelBuilder.Entity<Student>().ToTable(s => s.HasCheckConstraint("Rating", "Rating>-1 AND Rating<5").HasName("Check_Rating"));

            modelBuilder.Entity<Gruops>().Property(g => g.Name).HasMaxLength(20);
            modelBuilder.Entity<Gruops>().ToTable(s => s.HasCheckConstraint("Year", "Year>0 AND Year<5").HasName("Check_Year"));

        }
    }
}
