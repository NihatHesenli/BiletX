using Medicio_WEBSITE.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Medicio_WEBSITE.Areas.Manage.Controllers
{

    [Area("Manage")]
    public class DoctorController : Controller
    {
        private readonly AppDbContext _context;

        public DoctorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
        
            return View(_context.Doctors.ToList());
        }
    }
}
