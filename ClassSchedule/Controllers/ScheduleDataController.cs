using Microsoft.AspNetCore.Mvc;

namespace ClassSchedule.Controllers
{
    public class ScheduleDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
