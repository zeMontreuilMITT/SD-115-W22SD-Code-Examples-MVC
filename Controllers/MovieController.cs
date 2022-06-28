using Microsoft.AspNetCore.Mvc;
using SD_115_W22SD_Code_Examples_MVC.Models;

namespace SD_115_W22SD_Code_Examples_MVC.Controllers
{
    public class MovieController: Controller
    {
        public IActionResult Index()
        {
            // only show films from 2010 and later
            List<Film> newFilms = Database.Films.Where(iteratedFilm => iteratedFilm.Year > 2015).ToList();

            return View(newFilms);
        }

        public IActionResult Details(int? id, string? name)
        {
            Film searchedFilm;

            try
            {
                if (id != null)
                {
                    searchedFilm = Database.Films.First(iteratedFilm => iteratedFilm.Id == id);
                    return View(searchedFilm);
                }
                else if (!String.IsNullOrEmpty(name))
                {
                    searchedFilm = Database.Films.First(film => film.Title.ToLower().Contains(name.ToLower()));
                    return View(searchedFilm);
                } else
                {
                    throw new Exception("No parameters found");
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult Error(string message)
        {
            if(message == null)
            {
                message = "Something went wrong";
            }

            ViewBag.Message = message;
            return View();
        }
    }
}
