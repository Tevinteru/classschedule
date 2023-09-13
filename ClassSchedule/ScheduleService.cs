using Newtonsoft.Json;
using System.IO;

namespace ClassSchedule
{
    public class ScheduleService
    {
        public Schedule[] ParseSchedule(string jsonFilePath)
        {
            var jsonData = File.ReadAllText(jsonFilePath);
            var schedules = JsonConvert.DeserializeObject<Schedule[]>(jsonData);
            return schedules;
        }
    }
}
