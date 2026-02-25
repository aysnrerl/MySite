using Microsoft.AspNetCore.Mvc;

namespace MySite.ViewComponents
{
    public class AdminAboutViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
