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

            ViewBag.PageTitle = "All Films";
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

        public IActionResult MostExpensive()
        {
            /*
            Film expensiveFilm;

            double greatestBudget = Database.Films.Max(f => f.Budget);

            expensiveFilm = Database.Films.First(f => f.Budget == greatestBudget);

            return View("Details", expensiveFilm); */

            List<Film> filmsByBudget = Database.Films.OrderByDescending(f => f.Budget).ToList();

            ViewBag.PageTitle = "Most Expensive Films";
            return View("Index", filmsByBudget);
        }

        public IActionResult LeastExpensive()
        {
            List<Film> filmsByBudget = Database.Films.OrderBy(f => f.Budget).ToList();

            ViewBag.PageTitle = "Least Expensive Films";
            return View("Index", filmsByBudget);
        }

        public IActionResult AlphabeticFilms()
        {
            List<Film> alphabeticFilms = Database.Films.OrderBy(f => f.Title).ToList();

            ViewBag.PageTitle = "Philms by Alphabetic Order";
            return View("Index", alphabeticFilms);
        }

        public IActionResult BudgetRange(long? maxBudget = 0, long? minBudget = 0)
        {
            if(maxBudget != null && minBudget != null)
            {
                List<Film> filmsInRange = Database.Films.Where(f => f.Budget >= minBudget && f.Budget <= maxBudget).ToList();

                if(filmsInRange.Count <= 0)
                {
                    ViewBag.Message = "Didn't find any!";
                }

                ViewBag.PageTitle = $"Films between ${minBudget} and ${maxBudget}";
                return View("Index", filmsInRange);
            }

            return RedirectToAction("Error");
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
