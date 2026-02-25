using Microsoft.AspNetCore.Mvc;
using MySite.Models;

namespace MySite.ViewComponents
{
    public class _DefaultFeatureComponentPartial : ViewComponent
    {
        private readonly MySiteContext _context;

        public _DefaultFeatureComponentPartial(MySiteContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.TblFeatures.FirstOrDefault();
            return View(values);
        }
    }
}
