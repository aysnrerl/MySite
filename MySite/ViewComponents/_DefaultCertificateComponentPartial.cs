using Microsoft.AspNetCore.Mvc;
using MySite.Models;

namespace MySite.ViewComponents
{
    public class _DefaultCertificateComponentPartial : ViewComponent
    {
        private readonly MySiteContext _context;

        public _DefaultCertificateComponentPartial(MySiteContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.TblCertificates.ToList();
            return View(values);
        }
    }
}
