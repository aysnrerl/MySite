using Microsoft.AspNetCore.Mvc;

namespace MySite.ViewComponents
{
    public class AdminSideBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
