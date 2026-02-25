using Microsoft.AspNetCore.Mvc;
using MySite.Models;

namespace MySite.ViewComponents
{
    public class _DefaultExperienceComponentPartial : ViewComponent
    {
        private readonly MySiteContext _context;

        public _DefaultExperienceComponentPartial(MySiteContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.TblExperiences.ToList();
            return View(values);
        }
    }
}
