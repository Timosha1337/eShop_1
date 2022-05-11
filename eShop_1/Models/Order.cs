using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eShop_1.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public double Price { get; set; }
        public string Adress { get; set; }
        public string Status { get; set; }
        public List<Product> Products { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

    }
}
