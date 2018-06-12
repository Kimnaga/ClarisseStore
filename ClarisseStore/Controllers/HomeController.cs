using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClarisseStore.Models;

namespace ClarisseStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pria()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Wanita()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Hijab()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }


        public IActionResult Necklace()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Login()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Signup()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
