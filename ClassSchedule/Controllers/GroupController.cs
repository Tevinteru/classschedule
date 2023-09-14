using ClassSchedule.Data.DataModels;
using ClassSchedule.Data;
using Microsoft.AspNetCore.Mvc;

namespace ClassSchedule.Controllers
{
    public class GroupController : Controller
    {
        
        private readonly ApplicationDbContext _context;

        public GroupController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(GroupData groupData)
        {
            if (groupData.Name == null)
            {
                return View(groupData);
            }

            _context.Groups.Add(groupData);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
