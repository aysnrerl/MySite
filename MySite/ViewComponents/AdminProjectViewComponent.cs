using Microsoft.AspNetCore.Mvc;

namespace MySite.ViewComponents
{
    public class AdminProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
