using Microsoft.AspNetCore.Mvc;

namespace ClassSchedule.Controllers
{
    public class DayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
