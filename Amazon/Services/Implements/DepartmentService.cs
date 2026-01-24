using Amazon.Models;
using Amazon.Services.Interfaces;

namespace Amazon.Services.Implements
{
    public class DepartmentService : IDepartmentService
    {
        private List<Department> _departments = new List<Department>(); //muveqqeti yaddasdir.
        public void Create(int id, string name)
        {
            var department = new Department()
            {
                Id = id,
                Name = name
            };
            _departments.Add(department);
        }

        public void Delete(int id)
        {
            var department = _departments.FirstOrDefault(d => d.Id == id);
            if (department == null) Console.WriteLine("Department was not found!");
            else
            {
                _departments.Remove(department);

                Console.WriteLine($"{id} department was removed");
            }
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
            if (department == null) Console.WriteLine("Department was not found!");
            else Console.WriteLine($"Id: {department.Id} - Department: {department.Name}");
        }
    }
}
