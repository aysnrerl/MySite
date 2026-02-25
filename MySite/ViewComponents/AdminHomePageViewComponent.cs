using Microsoft.AspNetCore.Mvc;

namespace MySite.ViewComponents
{
    public class AdminHomePageViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
