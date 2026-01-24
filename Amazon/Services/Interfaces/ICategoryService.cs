namespace Amazon.Services.Interfaces
{
    public interface ICategoryService
    {
        void Create(int id, string name, int departmentId);
        void Delete(int id);
        void GetAll();
        void GetById(int id);
    }
}
