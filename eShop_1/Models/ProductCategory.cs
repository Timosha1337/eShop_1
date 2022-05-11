using System.Collections.Generic;

namespace eShop_1.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagURL { get; set; }
        public List<Product> Products { get; set; }
    }
}
