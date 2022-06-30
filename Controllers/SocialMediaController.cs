using Microsoft.AspNetCore.Mvc;
using SD_115_W22SD_Code_Examples_MVC.Models;

namespace SD_115_W22SD_Code_Examples_MVC.Controllers
{
    public class SocialMediaController : Controller
    {
        public IActionResult ViewAllUsers()
        {
            return View("UserList", Database.Users);
        }

        public IActionResult UserDetails(int? id)
        {
            if(id != null)
            {
                try
                {
                    User user = Database.Users.First(u => u.Id == id);
                    return View(user);
                }
                catch
                {
                    return RedirectToAction("Error", "Home");
                }
            }

            return RedirectToAction("Error", "Home");
        }

        [HttpGet]
        public IActionResult CreatePost(int userId)
        {
            try
            {
                User user = Database.Users.First(u => u.Id==userId);
                return View(user);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public IActionResult CreatePost(int userId, string content)
        {
            try
            {
                User postingUser = Database.Users.First(u => u.Id == userId);
                Post newPost = Database.CreatePost(content);

                newPost.User = postingUser;
                postingUser.Posts.Add(newPost);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }

            var routes = new { id = userId };
            return RedirectToAction("UserDetails", routes);
        }
    }
}
