using Amazon.DTOs.Department;
using Amazon.Exceptions.NotFoundExceptions;
using Amazon.Models;
using Amazon.Services.Interfaces;

namespace Amazon.Services.Implements
{
    public class DepartmentService : IGenericService<DepartmentCreateDto>
    {
        private List<Department> _departments = new List<Department>(); //muveqqeti yaddasdir.
        public void Create(DepartmentCreateDto dto)
        {
            var department = new Department()
            {
                Id = dto.Id,
                Name = dto.Name
            };
            _departments.Add(department);
        }

        public void Delete(int id)
        {
            var department = _departments.FirstOrDefault(d => d.Id == id);
            if (department == null) throw new DepartmentNotFoundException();
            _departments.Remove(department);

            Console.WriteLine($"{id} department was removed");
        }

        public void GetAll()
        {
            foreach (var department in _departments)
            {
                Console.WriteLine($"Id: {department.Id} - Department: {department.Name}");
            }
        }

        public void GetById(int id)
        {
            var department = _departments.FirstOrDefault(d => d.Id == id);
            if (department == null) throw new DepartmentNotFoundException();
            Console.WriteLine($"Id: {department.Id} - Department: {department.Name}");
        }
    }
}
