using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotificationCalendar.Core.Enums;
using NotificationCalendar.Domain.Day;
using System.Collections.Generic;

namespace NotificationCalendar.Data.PostgreSQL.Configuration
{
    /// <summary>
    /// Din Configuration To Seed Data
    /// </summary>
    public class DinConfiguration : IEntityTypeConfiguration<Din>
    {
        public void Configure(EntityTypeBuilder<Din> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.GregorianDate).IsRequired().HasColumnType("date");
            builder.Property(x => x.NepaliDate).IsRequired().HasColumnType("char(20)");
            builder.Property(x => x.NepaliYear).IsRequired().HasColumnType("bigint");
            builder.Property(x => x.NepaliMonth).IsRequired().HasColumnType("bigint");
            builder.Property(x => x.NepaliDay).IsRequired().HasColumnType("bigint");
            IList<Din> dinHaru = BSYear.GetDaysOfYear();
            builder.HasData(dinHaru);
        }
    }
}
