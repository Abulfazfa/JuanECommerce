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
            homeVM.Products = _appDbContext.Products.Include(p=>p.Images).AsNoTracking().ToList();
            homeVM.Sliders = _appDbContext.Sliders.Include(s=>s.SliderContent).AsNoTracking().ToList();
            homeVM.Blogs = _appDbContext.Blogs.AsNoTracking().ToList();
            homeVM.Banners = _appDbContext.Banners.AsNoTracking().ToList();
            homeVM.Brands = _appDbContext.Brands.AsNoTracking().ToList();
            return View(homeVM);
        }
        public IActionResult Search(string search)
        {
            var products = _appDbContext.Products.Include(p=>p.Images)
                .Where(p => p.Name.ToLower().Contains(search.ToLower()))
                .Take(3)
                .OrderByDescending(p => p.Id)
                .ToList();
            return PartialView("_SearcPartialView",products);
        }

   

    }
}