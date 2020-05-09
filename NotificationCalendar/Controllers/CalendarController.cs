using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotificationCalendar.Domain.Day;
using NotificationCalendar.Service;

namespace NotificationCalendar.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalendarController : ControllerBase
    {
        private readonly ICalendarService _calendarService;
        private readonly ILogger<CalendarController> _logger;
        public CalendarController(ICalendarService calendarService, ILogger<CalendarController> logger)
        {
            _calendarService = calendarService;
            _logger = logger;
        }

        // GET api/values
        /// <summary>
        /// Get Strings
        /// </summary>
        /// <returns>Enumrable of strings</returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get all available Days
        /// </summary>
        /// <returns>Enumerable of all available Days</returns>
        [HttpGet]
        public async Task<IAsyncEnumerable<Din>> GetDays()
        {
            return await _calendarService.GetDinsAsync();
        }

        /// <summary>
        /// Get all available Days of the particular month
        /// </summary>
        /// <param name="month">Month</param>
        /// <returns>Enumeration of Days</returns>
        [HttpGet]
        public async Task<IAsyncEnumerable<Din>> GetDaysByMonth(int month)
        {
            return await _calendarService.GetDaysByMonthAsync(month);
        }

        /// <summary>
        /// Get all available Days of the current month
        /// </summary>
        /// <returns>Enumeration of Days</returns>
        [HttpGet]
        public async Task<IAsyncEnumerable<Din>> GetCurrentMonthAsync()
        {
            return await _calendarService.GetCurrentMonthAsync();
        }
    }
}
