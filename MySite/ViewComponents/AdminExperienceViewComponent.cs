using Microsoft.AspNetCore.Mvc;

namespace MySite.ViewComponents
{
    public class AdminExperienceViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
