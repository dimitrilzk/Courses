using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class CoursesController : Controller
    {
        //public IActionResult Details([FromRoute(Name = "id")] string CourseId, [FromQuery(Name = "p")] string prova)
        //{
        //    return Content($"Sono Detail con id {CourseId}");
        //}
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(string id)
        {
            return View();
        }

    }
}
