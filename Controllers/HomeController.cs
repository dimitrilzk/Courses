using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Sono la index della pagina Home");
        }
    }
}
