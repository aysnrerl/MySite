using Microsoft.AspNetCore.Mvc;

namespace MySite.ViewComponents
{
    public class AdminSkillViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
