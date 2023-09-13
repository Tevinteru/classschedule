using System.ComponentModel.DataAnnotations.Schema;

namespace ClassSchedule.Data.DataModels
{
    public class DayData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GroupData Group { get; set; }
        public List<LessonData> LessonsEvenWeek { get; set; } // Уроки для четной недели
        public List<LessonData> LessonsOddWeek { get; set; } // Уроки для нечетной недели
    }
}
