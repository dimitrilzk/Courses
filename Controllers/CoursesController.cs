using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication4.Models.Services.Application;
using WebApplication4.Models.ViewModels;

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
            var courseService = new CourseService();
            List<CourseViewModel> courses= courseService.GetServices();
            return View(courses);
        }
        public IActionResult Detail(string id)
        {
            return View();
        }

    }
}
