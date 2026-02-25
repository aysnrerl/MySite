using Microsoft.AspNetCore.Mvc;

namespace MySite.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
