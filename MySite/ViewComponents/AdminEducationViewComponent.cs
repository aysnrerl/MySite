using Microsoft.AspNetCore.Mvc;

namespace MySite.ViewComponents
{
    public class AdminEducationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
