using Microsoft.AspNetCore.Mvc;
using Project.web.Models;
using System.Diagnostics;

namespace Project.web.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ForgetPassword()
        {
            return View();
        }

        public IActionResult ResetPassword()
        {
            return View();
        }
    }
}