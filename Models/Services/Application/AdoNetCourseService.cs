using System.Collections.Generic;
using System.Data;
using WebApplication4.Models.Services.Infrastructure;
using WebApplication4.Models.ViewModels;

namespace WebApplication4.Models.Services.Application
{
    public class AdoNetCourseService : ICourseService
    {
        private readonly IDatabaseAccessor db;

        public AdoNetCourseService(IDatabaseAccessor db)
        {
            this.db = db;
        }
        public CourseDetailViewModel GetCourse(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<CourseViewModel> GetCourses()
        {
            string query = "SELECT * FROM Courses";
            DataSet dataSet = db.Query(query);
            throw new System.NotImplementedException();
        }
    }
}
