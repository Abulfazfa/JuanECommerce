﻿namespace JuanFrontToBack.Models
{
    public class ProductImg
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public bool IsMain { get; set; }
        public Product Product { get; set; }
    }
}
