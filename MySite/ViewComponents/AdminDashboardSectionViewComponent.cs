using Microsoft.AspNetCore.Mvc;

namespace MySite.ViewComponents
{
    public class AdminDashboardSectionViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // You can add any logic here to prepare data for the view if needed
            return View();
        }
    }
}
