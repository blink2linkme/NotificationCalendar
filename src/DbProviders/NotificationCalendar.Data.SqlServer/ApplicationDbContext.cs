using Microsoft.EntityFrameworkCore;
using NotificationCalendar.Data.Configuration;
using NotificationCalendar.Domain.Day;

namespace NotificationCalendar.Data.SqlServer
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DinConfiguration());
        }

        public virtual DbSet<Din> Dins { get; set; }
    }
}
