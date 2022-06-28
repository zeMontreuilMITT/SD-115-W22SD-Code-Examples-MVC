using Microsoft.AspNetCore.Mvc;
using SD_115_W22SD_Code_Examples_MVC.Models;

namespace SD_115_W22SD_Code_Examples_MVC.Controllers
{
    public class MovieController: Controller
    {
        public IActionResult Index()
        {
            return View(Database.Films);
        }

        public IActionResult Details(int? id)
        {
            Film searchedFilm = Database.Films.Last();

            return View(searchedFilm);
        }
    }
}
