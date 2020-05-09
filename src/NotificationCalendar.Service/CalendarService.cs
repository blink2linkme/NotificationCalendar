using Microsoft.Extensions.Logging;
using NotificationCalendar.Domain.Day;
using System.Collections.Generic;
using System.Threading.Tasks;
using NotificationCalendar.Repository;

namespace NotificationCalendar.Service
{
    public class CalendarService : ICalendarService
    {
        private readonly ICalendarRepository _repository;
        private readonly ILogger<CalendarService> _logger;

        public CalendarService(ICalendarRepository repository, ILogger<CalendarService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<IAsyncEnumerable<Din>> GetDaysByMonthAsync(int month)
        {
            return await _repository.GetDaysByMonthAsync(month);
        }

        public async Task<IAsyncEnumerable<Din>> GetDinsAsync()
        {
            return await _repository.GetDinsAsync();
        }

        public async Task<IAsyncEnumerable<Din>> GetCurrentMonthAsync()
        {
            return await _repository.GetCurrentMonthAsync();
        }
    }
}
