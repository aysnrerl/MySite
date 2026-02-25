using Microsoft.AspNetCore.Mvc;

namespace MySite.ViewComponents
{
    public class AdminHeadViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
