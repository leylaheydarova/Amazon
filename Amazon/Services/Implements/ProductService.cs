using Amazon.DTOs.Product;
using Amazon.Exceptions.InvalidExceptions;
using Amazon.Exceptions.NotFoundExceptions;
using Amazon.Extensions;
using Amazon.Models;
using Amazon.Services.Interfaces;

namespace Amazon.Services.Implements
{
    public class ProductService : IGenericService<ProductCreateDto>
    {
        private List<Product> _products = new List<Product>();
        public void Create(ProductCreateDto dto)
        {
            var result = dto.Price.IsGreaterThanZero();

            if (!result) throw new PriceException();
            var product = new Product()
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                ImageUrl = dto.ImageUrl,
                CategoryId = dto.CategoryId,
                Price = dto.Price,
                DiscountedPrice = (dto.Price * (100 - dto.DiscountPersentage)) / 100
            };

            _products.Add(product);
            Console.WriteLine("Product was added successfully!");
        }

        public void Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null) throw new ProductNotFoundException();

            _products.Remove(product);
            Console.WriteLine("Product was removed successfully!");
        }

        public void GetAll()
        {
            foreach (var product in _products)
            {
                Console.WriteLine($"{product.Id} - {product.Name}, ${product.DiscountedPrice}\n{product.Description}, Original:${product.Price}\n");
            }
        }

        public void GetById(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null) throw new ProductNotFoundException();
            Console.WriteLine($"{product.Id} - {product.Name}, ${product.DiscountedPrice}\n{product.Description}, Original:${product.Price}\n");
        }
    }
}
