using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NotificationCalendar.Helper
{
    public class DayConfiguration : IEntityTypeConfiguration<Din>
    {
        public void Configure(EntityTypeBuilder<Din> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.GregorianDate).IsRequired().HasColumnType("DateTime");
            builder.Property(x => x.NepaliDate).IsRequired().HasColumnType("varchar(10)");
            builder.Property(x => x.NepaliYear).IsRequired().HasColumnType("int");
            builder.Property(x => x.NepaliMonth).IsRequired().HasColumnType("int");
            builder.Property(x => x.NepaliDay).IsRequired().HasColumnType("int");
            builder.ToTable("day_table");
        }
    }
}
