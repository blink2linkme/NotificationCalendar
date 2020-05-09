using NotificationCalendar.Domain.Day;
using System;
using System.Collections.Generic;

namespace NotificationCalendar.Core.Enums
{
    /// <summary>
    /// Represents an entity of BSYear with all preloaded values
    /// </summary>
    public static class BSYear
    {
        public static DateTime refGregorianDate = new DateTime(2020, 4, 13);
        public static DateTime refNepaliDate = new DateTime(2077, 1, 1);

        public static Dictionary<int, int[]> bsCalendars = new Dictionary<int, int[]>
        {
            { 2077, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31} }
        };

        public static IList<Din> GetDaysOfYear()
        {
            IList<Din> dinharu = new List<Din>();
            int daysCount = 0;
            foreach (var bsCalendar in bsCalendars)
            {
                for (int m = 1; m <= bsCalendar.Value.Length; m++)
                {
                    for (int i = 1; i <= bsCalendar.Value[m - 1]; i++)
                    {
                        daysCount++;
                        var din = new Din
                        {
                            Id = daysCount,
                            GregorianDate = refGregorianDate.AddDays(daysCount - 1),
                            NepaliYear = bsCalendar.Key,
                            NepaliMonth = m,
                            NepaliDay = i,
                            NepaliDate = bsCalendar.Key + "/" + m + "/" + i
                        };
                        dinharu.Add(din);
                    }
                }
            }
            return dinharu;
        }
    }
}
