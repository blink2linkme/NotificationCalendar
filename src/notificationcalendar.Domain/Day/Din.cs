using System;

namespace NotificationCalendar.Domain.Day
{
    /// <summary>
    /// Represents an entity for Day
    /// </summary>
    public class Din
    {
        public int Id { get; set; }
        public DateTime GregorianDate { get; set; }
        //Bikram Sambat Year as 2077
        public int NepaliYear { get; set; }
        //Bikram Sambat Month as 01
        public int NepaliMonth { get; set; }
        //Bikram Sambat Month as 16
        public int NepaliDay { get; set; }
        //Bikram Sambat Nepai Full Date as 2077/01/16
        public string NepaliDate { get; set; }
        //Example Column
        //public bool IsHoliday { get; set; } = true;
    }
}
