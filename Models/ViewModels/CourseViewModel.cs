using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using WebApplication4.Models.ValueTypes;

namespace WebApplication4.Models.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }    
        public string ImagePath { get; set; }
        public string Author { get; set; }
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = false)]
        public double Rating { get; set; }
        public Money FullPrice { get; set; }
        public Money CurrentPrice { get; set; }
        
    }
}
