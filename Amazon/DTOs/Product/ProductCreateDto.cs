namespace Amazon.DTOs.Product
{
    public class ProductCreateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int DiscountPersentage { get; set; } //endirim faizi
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
