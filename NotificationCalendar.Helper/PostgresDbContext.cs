using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace NotificationCalendar.Helper
{
    public class PostgresDbContext : DbContext
    {
        //public PostgresDbContext(string connectionString) : base()
        //{

        //}
        public PostgresDbContext(DbContextOptions<PostgresDbContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql(@"Host=localhost;Port=50101;Username=postgres;Password=123;Database=NotificationCalendars;");
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.ApplyConfiguration(new DayConfiguration());
        //}

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }

        //public virtual DbSet<Din> Days { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
