using JuanFrontToBack.DEL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JuanFrontToBack.ViewCompenents
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public ProductViewComponent(AppDbContext appDbContex)
        {
            _appDbContext = appDbContex;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var product = _appDbContext.Products.Include(p => p.Images).ToList();
            return View(await Task.FromResult(product));
        }
    }
}
