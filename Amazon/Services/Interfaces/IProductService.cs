using Amazon.DTOs.Product;

namespace Amazon.Services.Interfaces
{
    public interface IProductService
    {
        void Create(ProductCreateDto dto);
        void Delete(int id);
        void GetAll();
        void GetById(int id);
    }
}
