using Microsoft.AspNetCore.Mvc;

namespace ClassSchedule.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
