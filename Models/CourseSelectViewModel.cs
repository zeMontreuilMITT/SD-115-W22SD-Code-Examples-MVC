using Microsoft.AspNetCore.Mvc.Rendering;

namespace SD_115_W22SD_Code_Examples_MVC.Models
{
    public class CourseSelectViewModel
    {
        public Course? Course { get; set; }
        public List<SelectListItem> SelectCourses { get; set; } = new List<SelectListItem>();

        public CourseSelectViewModel(Course course, ICollection<Course> listCourses)
        {
            Course = course;
            
            foreach(Course c in listCourses)
            {
                SelectCourses.Add(new SelectListItem { Value = c.Id.ToString(), Text = c.Title });
            }
        }

        public CourseSelectViewModel(ICollection<Course> listCourses)
        {
            foreach (Course c in listCourses)
            {
                SelectCourses.Add(new SelectListItem { Value = c.Id.ToString(), Text = c.Title });
            }
        }
    }
}
