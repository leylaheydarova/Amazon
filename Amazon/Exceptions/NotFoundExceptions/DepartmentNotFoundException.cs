namespace Amazon.Exceptions.NotFoundExceptions
{
    public class DepartmentNotFoundException : NotFoundException
    {
        public DepartmentNotFoundException() : base("Department")
        {
        }
    }
}
