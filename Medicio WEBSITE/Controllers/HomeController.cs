using Microsoft.AspNetCore.Mvc;

namespace Medicio_WEBSITE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
    }
}
