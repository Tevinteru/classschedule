namespace ClassSchedule
{
    public class Schedule
    {
        public string Group { get; set; }
        public Days Days { get; set; }
    }

    public class Days
    {
        public Day MON { get; set; }
        public Day TUE { get; set; }
        public Day WED { get; set; }
        public Day THU { get; set; }
        public Day FRI { get; set; }
        public Day SAT { get; set; }
    }

    public class Day
    {
        public Lessons? a { get; set; }
        public Lessons? b { get; set; }
    }

    public class Lessons
    {
        public string? p1 { get; set; }
        public string? p2 { get; set; }
        public string? p3 { get; set; }
        public string? p4 { get; set; }
        public string? p5 { get; set; }
        public string? p6 { get; set; }
    }
}
