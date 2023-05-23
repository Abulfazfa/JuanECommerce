namespace JuanFrontToBack.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        public string Desc { get; set; }
        public int Rating { get; set; }
        public bool IsBestSeller { get; set; }
        public List<ProductImg> Images { get; set; }
    }
}
