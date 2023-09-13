namespace ClassSchedule.Data.DataModels
{
    public class ScheduleData
    {
        public int Id { get; set; }
        public GroupData Group { get; set; }
        public List<DayData> Days { get; set; }
    }
}
