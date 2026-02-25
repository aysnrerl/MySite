using Microsoft.AspNetCore.Mvc;

namespace MySite.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
