using Microsoft.AspNetCore.Mvc;
using MySite.Models;

namespace MySite.ViewComponents
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        private readonly MySiteContext _context;

        public _DefaultFooterComponentPartial(MySiteContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.TblFooters.FirstOrDefault();
            return View(values);
        }
    }
}
