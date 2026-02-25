using Microsoft.AspNetCore.Mvc;

namespace MySite.Controllers
{
    public class AdminHomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
