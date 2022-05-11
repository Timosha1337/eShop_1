using System.Collections.Generic;

namespace eShop_1.Models
{
    public class User
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string PassWord { get; set; }
        public string PhoneNumber { get; set; }

        public List<Order> Orders { get; set; }
    }
}
