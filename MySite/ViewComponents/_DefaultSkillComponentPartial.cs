using Microsoft.AspNetCore.Mvc;
using MySite.Models;

namespace MySite.ViewComponents
{
    public class _DefaultSkillComponentPartial : ViewComponent
    {
        private readonly MySiteContext _context;

        public _DefaultSkillComponentPartial(MySiteContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.TblSkills.ToList();
            return View(values);
        }
    }
}
