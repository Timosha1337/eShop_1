using eShop_1.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop_1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double RAM { get; set; }//оперативка
        public double ROM { get; set; }//постоянная
        public string Description { get; set; }
        public double Price { get; set; }
        public string Colour { get; set; }
        public string ImagURL { get; set; }
        public bool InStok { get; set; }  
        public ProductCategory Category { get; set; }
        public int CategoryId { get; set; }
        //Relationships
        public Brand Brand { get; set; }
        public int BrandId { get; set; }

        public Order Order { get; set; }
    }
}
