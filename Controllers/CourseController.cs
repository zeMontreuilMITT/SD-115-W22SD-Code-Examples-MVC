using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SD_115_W22SD_Code_Examples_MVC.Models;

namespace SD_115_W22SD_Code_Examples_MVC.Controllers
{
    public class CourseController: Controller
    {
        public IActionResult Index()
        {

            return View(Database.Courses);
        }

        [HttpGet]
        public IActionResult Details(int? Id)
        {
            CourseSelectViewModel vm;
            if(Id == null)
            {
                vm = new CourseSelectViewModel(Database.Courses);
            } else
            {
                Course foundCourse = Database.Courses.First(c => c.Id == Id);
                vm = new CourseSelectViewModel(foundCourse, Database.Courses);
            }

            return View(vm);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string Title)
        {
            Database.CreateCourse(Title);
            return RedirectToAction("Create");
        }
    }
}
