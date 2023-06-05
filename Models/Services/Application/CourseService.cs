using System;
using System.Collections.Generic;
using WebApplication4.Models.Enums;
using WebApplication4.Models.ValueTypes;
using WebApplication4.Models.ViewModels;

namespace WebApplication4.Models.Services.Application
{
    public class CourseService
    {
        public List<CourseViewModel> GetServices()
        {
            var courseList = new List<CourseViewModel>();
            var rand = new Random();
            for(int i = 1; i <= 20; i++)
            {
                var price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
                var course = new CourseViewModel
                {
                    Id = i,
                    Title = $"Corso {i}",
                    CurrentPrice = new Money(Currency.EUR, price),
                    FullPrice = new Money(Currency.EUR, rand.NextDouble() > 0.5 ? price : price - 1),
                    Author = "Nome Cognome",
                    Rating = rand.NextDouble() * 5.0,
                    ImagePath = "~log.png"
                };
                courseList.Add(course);
            }
            return courseList;
        }
    }
}
