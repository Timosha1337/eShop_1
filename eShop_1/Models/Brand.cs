using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eShop_1.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string OffcialURL { get; set; }
        public string Name { get; set; }
        public string ImagURL { get; set; }
        public string Bio { get; set; }
        // Relationships
        public List<Product> Products { get; set; }
        //public List<Brand_Product> Brand_Products { get; set; }
    }
}
