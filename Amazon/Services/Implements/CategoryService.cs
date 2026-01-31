using Amazon.Exceptions.NotFoundExceptions;
using Amazon.Models;
using Amazon.Services.Interfaces;

namespace Amazon.Services.Implements
{
    public class CategoryService : ICategoryService
    {
        private List<Category> _categories = new List<Category>();

        public void Create(int id, string name, int departmentId)
        {
            var category = new Category()
            {
                Id = id,
                Name = name,
                DepartmentId = departmentId
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
