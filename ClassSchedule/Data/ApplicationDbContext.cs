using Microsoft.EntityFrameworkCore;
using ClassSchedule.Data.DataModels;

namespace ClassSchedule.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<GroupData> Groups { get; set; }
        public DbSet<ScheduleData> Schedules { get; set; }
        public DbSet<DayData> Days { get; set; }
        public DbSet<LessonData> Lessons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LessonData>()
                .HasOne<DayData>(l => l.DayDataEvenWeek)
                .WithMany(d => d.LessonsEvenWeek)
                .HasForeignKey(l => l.DayDataEvenWeekId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LessonData>()
                .HasOne<DayData>(l => l.DayDataOddWeek)
                .WithMany(d => d.LessonsOddWeek)
                .HasForeignKey(l => l.DayDataOddWeekId)
                .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
