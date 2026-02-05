using Amazon.DTOs.Category;
using Amazon.Exceptions.NotFoundExceptions;
using Amazon.Models;
using Amazon.Services.Interfaces;

namespace Amazon.Services.Implements
{
    public class CategoryService : IGenericService<CategoryCreateDto>
    {
        private List<Category> _categories = new List<Category>();

        public void Create(CategoryCreateDto dto)
        {
            var category = new Category()
            {
                Id = dto.Id,
                Name = dto.Name,
                DepartmentId = dto.DepartmentId
            };
            _categories.Add(category);
            Console.WriteLine("Category was created successfully!");
        }

        public void Delete(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category == null) throw new CategoryNotFoundException();
            _categories.Remove(category);
            Console.WriteLine("Category was removed successfully!");
        }

        public void GetAll()
        {
            foreach (var category in _categories)
            {
                Console.WriteLine($"Id:{category.Id} - Category:{category.Name} - DepartmentId:{category.DepartmentId}");
            }
        }

        public void GetById(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category == null) throw new CategoryNotFoundException();
            Console.WriteLine($"Id:{category.Id} - Category:{category.Name} - DepartmentId:{category.DepartmentId}");
        }
    }
}
//extend - genislendirmek
