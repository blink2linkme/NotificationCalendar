using Microsoft.EntityFrameworkCore;
using NotificationCalendar.Data.PostgreSQL.Configuration;
using NotificationCalendar.Domain.Day;

namespace NotificationCalendar.Data.SqlServer
{
    public class ApplicationNpgDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationNpgDbContext(DbContextOptions<ApplicationNpgDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DinConfiguration());
        }

        public virtual DbSet<Din> Dins { get; set; }
    }
}
