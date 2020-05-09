using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using NotificationCalendar.Domain.Day;
using NotificationCalendar.Data.SqlServer;

namespace NotificationCalendar.Repository
{
    /// <summary>
    /// Represents a Repository for Calendar
    /// </summary>
    public class CalendarRepository : ICalendarRepository
    {
        private readonly IApplicationDbContext _dbContext;
        private readonly ILogger<CalendarRepository> _logger;

        public CalendarRepository(IApplicationDbContext dbContext, ILogger<CalendarRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<IAsyncEnumerable<Din>> GetDaysByMonthAsync(int month)
        {
            return _dbContext.Dins.Where(x => x.NepaliMonth == month).AsAsyncEnumerable();
        }

        public async Task<IAsyncEnumerable<Din>> GetDinsAsync()
        {
            return _dbContext.Dins.AsAsyncEnumerable();
        }

        public async Task<IAsyncEnumerable<Din>> GetCurrentMonthAsync()
        {
            DateTime dt = DateTime.Now;
            var currentNepaliDate = await _dbContext.Dins.FirstOrDefaultAsync(x => x.GregorianDate.Year == dt.Year && x.GregorianDate.Month == dt.Month && x.GregorianDate.Day == dt.Day);
            return _dbContext.Dins.Where(x => x.NepaliMonth == currentNepaliDate.NepaliMonth).AsAsyncEnumerable();
        }
    }
}