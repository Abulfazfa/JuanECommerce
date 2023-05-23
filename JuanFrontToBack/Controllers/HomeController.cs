using JuanFrontToBack.DEL;
using JuanFrontToBack.Models;
using JuanFrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace JuanFrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new();
            homeVM.Products = _appDbContext.Products.Include(p=>p.Images).ToList();
            homeVM.Sliders = _appDbContext.Sliders.ToList();
            homeVM.SliderContents = _appDbContext.SliderContents.ToList();
            homeVM.Blogs = _appDbContext.Blogs.ToList();
            homeVM.Banners = _appDbContext.Banners.ToList();
            homeVM.Brands = _appDbContext.Brands.ToList();
            return View(homeVM);
        }

   

    }
}