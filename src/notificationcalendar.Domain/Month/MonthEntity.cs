namespace NotificationCalendar.Domain
{
    /// <summary>
    /// Represents an Entity for Month
    /// </summary>
    public class MonthEntity
    {
        public int MonthValue { get; set; }
        public int MonthDateValue { get; set; }
        public string Name { get; set; }
        public string MonthEnglishName { get; set; }

    }
}