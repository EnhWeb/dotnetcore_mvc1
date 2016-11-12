using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_mvc1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Pomelo.Data.MySql.MySqlConnection con = new Pomelo.Data.MySql.MySqlConnection("");
            

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
