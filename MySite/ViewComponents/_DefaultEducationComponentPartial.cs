using Microsoft.AspNetCore.Mvc;
using MySite.Models;

namespace MySite.ViewComponents
{
    public class _DefaultEducationComponentPartial : ViewComponent
    {
        private readonly MySiteContext _context;

        public _DefaultEducationComponentPartial(MySiteContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.TblEducations.FirstOrDefault();
            return View(values);
        }
    }
}
