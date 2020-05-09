using Microsoft.EntityFrameworkCore;
//using NotificationCalendar.Data.Configuration;
using NotificationCalendar.Domain.Day;

namespace NotificationCalendar.Data.SqlServer
{
    public interface IApplicationDbContext
    {
        DbSet<Din> Dins { get; set; }
    }
}
