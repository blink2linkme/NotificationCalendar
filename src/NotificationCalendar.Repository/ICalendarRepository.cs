using System.Collections.Generic;
using System.Threading.Tasks;
using NotificationCalendar.Domain.Day;

namespace NotificationCalendar.Repository
{
    /// <summary>
    /// Represents a Repository for Calendar
    /// </summary>
    public interface ICalendarRepository
    {
        /// <summary>
        /// An asynchronous method to get days
        /// </summary>
        /// <returns>List of Days</returns>
        Task<IAsyncEnumerable<Din>> GetDinsAsync();

        /// <summary>
        /// An asynchronous method to get days for the given month
        /// </summary>
        /// <returns>Enumeration of Days</returns>
        Task<IAsyncEnumerable<Din>> GetDaysByMonthAsync(int month);

        /// <summary>
        /// An asynchronous method to get Days in Month
        /// </summary>
        /// <returns>Enumeration of Days</returns>
        Task<IAsyncEnumerable<Din>> GetCurrentMonthAsync();
    }
}