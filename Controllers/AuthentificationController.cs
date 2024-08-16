using GamingShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GamingShop.Controllers
{
    public class AuthentificationController : Controller
    {
        public IActionResult RegisterPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(User registerUser)
        {
            return View();
        }
    }
}
