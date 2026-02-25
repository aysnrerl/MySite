using Microsoft.AspNetCore.Mvc;
using MySite.Models;

namespace MySite.ViewComponents
{
    public class _DefaultProjectComponentPartial : ViewComponent
    {
        private readonly MySiteContext context;

        public _DefaultProjectComponentPartial()
        {
            context = new MySiteContext();
        }

        public IViewComponentResult Invoke()
        {
            var values = context.TblProjects.ToList();
            return View(values);
        }
    }
}
