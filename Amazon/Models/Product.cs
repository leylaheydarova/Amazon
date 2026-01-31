namespace Amazon.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; } // mes, 100 qiymetidir. DTO-dan 20 faiz endirim gelir
        public double DiscountedPrice { get; set; } //endirimli qiymet, qiymetinin 80-a endiyini ozumuz hesablayiriq.
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}

//Data Transfer Object