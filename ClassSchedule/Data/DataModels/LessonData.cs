using ClassSchedule.Data.DataModels;
using System.ComponentModel.DataAnnotations.Schema;

public class LessonData
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Teacher { get; set; }
    public string Cabinet { get; set; }

    // Внешний ключ для четной недели
    [ForeignKey("DayDataEvenWeek")]
    public int? DayDataEvenWeekId { get; set; }
    public DayData DayDataEvenWeek { get; set; }

    // Внешний ключ для нечетной недели
    [ForeignKey("DayDataOddWeek")]
    public int? DayDataOddWeekId { get; set; }
    public DayData DayDataOddWeek { get; set; }
}
