using JuanFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JuanFrontToBack.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

   

    }
}