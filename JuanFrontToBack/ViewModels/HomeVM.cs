using JuanFrontToBack.Models;

namespace JuanFrontToBack.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<SliderContent> SliderContents { get; set; }
        public List<Product> Products { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Banner> Banners { get; set; }
        public List<Brand> Brands { get; set; }

    }
}
