using System.Collections.Generic;
using WebApplication4.Models.ViewModels;

namespace WebApplication4.Models.Services.Application
{
    public interface ICourseService
    {
        List<CourseViewModel>GetCourses();
        CourseDetailViewModel GetCourse(int id);
    }
}
