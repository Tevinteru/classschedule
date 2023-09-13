using Microsoft.AspNetCore.Mvc;

namespace ClassSchedule.Controllers
{
    public class LessonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
