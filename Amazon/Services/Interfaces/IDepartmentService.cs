namespace Amazon.Services.Interfaces
{
    public interface IDepartmentService
    {
        void Create(int id, string name);
        void Delete(int id);
        void GetAll();
        void GetById(int id);
    }
}
