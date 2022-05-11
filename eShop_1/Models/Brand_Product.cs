namespace eShop_1.Models
{
    public class Brand_Product
    {
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
