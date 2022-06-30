using Microsoft.AspNetCore.Mvc;
using SD_115_W22SD_Code_Examples_MVC.Models;

namespace SD_115_W22SD_Code_Examples_MVC.Controllers
{
    public class SocialMedia : Controller
    {
        public IActionResult ViewAllUsers()
        {
            return View("UserList", Database.Users);
        }
    }
}
