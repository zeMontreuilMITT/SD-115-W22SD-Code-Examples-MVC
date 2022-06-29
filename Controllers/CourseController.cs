using Microsoft.AspNetCore.Mvc;
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
