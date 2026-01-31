namespace Amazon.Exceptions.NotFoundExceptions
{
    public class ProductNotFoundException : NotFoundException
    {
        public ProductNotFoundException() : base("Product")
        {
        }
    }
}
