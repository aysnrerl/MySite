using Microsoft.AspNetCore.Mvc;
using MySite.Models;

namespace MySite.ViewComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        private readonly MySiteContext _context;

        public _DefaultAboutComponentPartial(MySiteContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.TblAbouts.FirstOrDefault();
            return View(values);
        }
    }
}
