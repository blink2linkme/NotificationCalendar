using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace NotificationCalendar.Helper
{
    public class Class1
    {
        public void CalendarYear()
        {
            DateTime refGregorianDate = new DateTime(2020, 4, 13);
            DateTime refNepaliDate = new DateTime(2077, 1, 1);

            Dictionary<int, int[]> bsCalendars = new Dictionary<int, int[]>
            {
                {2077, new int[]{ 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31} }
            };

            List<Din> dinharu = new List<Din>();
            int countDays = 0;
            foreach (var bsCalendar in bsCalendars)
            {
                for (int m = 1; m <= bsCalendar.Value.Length; m++)
                {
                    for (int i = 1; i <= bsCalendar.Value[m - 1]; i++)
                    {
                        countDays++;
                        var din = new Din
                        {
                            GregorianDate = refGregorianDate.AddDays(countDays - 1),
                            NepaliYear = bsCalendar.Key,
                            NepaliMonth = m,
                            NepaliDay = i,
                            NepaliDate = bsCalendar.Key + "/" + m + "/" + i
                        };
                        dinharu.Add(din);
                        //using (PostgresDbContext dbContext = new PostgresDbContext())
                        //{
                        //    dbContext.Days.Add(din);
                        //    dbContext.SaveChanges();
                        //}
                        Console.WriteLine($"{refGregorianDate.AddDays(countDays - 1)} {bsCalendar.Key + "/" + m + "/" + i}");
                    }
                }
            }
        }

        public void ShowCalendar()
        {
            try
            {
                //using (PostgresDbContext dbContext = new PostgresDbContext())
                //{
                //    var calendars = dbContext.Days.ToList();
                //    foreach (var calendar in calendars)
                //        Console.WriteLine($"{calendar.GregorianDate} {calendar.NepaliDate}");
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    [Table("Day_Table")]
    public class Din
    {
        public int Id { get; set; }
        public DateTime GregorianDate { get; set; }
        public int NepaliYear { get; set; }
        public int NepaliMonth { get; set; }
        public int NepaliDay { get; set; }
        public string NepaliDate { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        // from the group model (Entity framework will connect the Primarykey and forign key)
        //public Group Group { get; set; }
        public int GroupId { get; set; }
    }
}
