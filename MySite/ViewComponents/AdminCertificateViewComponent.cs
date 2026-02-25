using Microsoft.AspNetCore.Mvc;

namespace MySite.ViewComponents
{
    public class AdminCertificateViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
