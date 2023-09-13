using Microsoft.AspNetCore.Mvc;

namespace ClassSchedule.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScheduleController : ControllerBase
    {
        private readonly ScheduleService _scheduleService;
        private readonly IWebHostEnvironment _env;

        public ScheduleController(ScheduleService scheduleService, IWebHostEnvironment env)
        {
            _scheduleService = scheduleService;
            _env = env;
        }

        [HttpGet]
        public Schedule[] Get()
        {
            var path = Path.Combine(_env.ContentRootPath, "Data", "schedule.json");
            return _scheduleService.ParseSchedule(path);
        }
    }
}
