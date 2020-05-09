
namespace NotificationCalendar.Domain
{
    /// <summary>
    /// Represents an entity for Day
    /// </summary>
    public class DayEntity
    {
        // Sun = 0, Mon = 1, Tue = 2 DayArray Value of Day
        public int DayValue { get; set; }
        //Date or Gate
        public int DayDateValue { get; set; }
        //Full Date
        public int DayDate { get; set; }
        //Nepali full Date
        public string DayNepaliDate { get; set; }
        //Number of Events
        public int EventCount { get; set; }
        //Tithi
        public string Tithi { get; set; }
        //Color of the Day
        public string DayColor { get; set; }
        //Background Color of the Day Like Red for Holiday
        public string DayBackgroundColor { get; set; }
    }

}