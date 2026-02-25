using Microsoft.AspNetCore.Mvc;

namespace MySite.ViewComponents
{
    public class AdminContactViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
