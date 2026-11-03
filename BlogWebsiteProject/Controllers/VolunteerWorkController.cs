using Microsoft.AspNetCore.Mvc;

namespace BlogWebsiteProject.Controllers
{
    public class VolunteerWorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FoodBank()
        {
            return View();
        }
    }
}
