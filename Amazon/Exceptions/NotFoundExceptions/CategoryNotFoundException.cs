namespace Amazon.Exceptions.NotFoundExceptions
{
    public class CategoryNotFoundException : NotFoundException
    {
        public CategoryNotFoundException() : base("Category")
        {
        }
    }
}
