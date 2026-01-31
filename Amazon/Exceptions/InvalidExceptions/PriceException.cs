namespace Amazon.Exceptions.InvalidExceptions
{
    public class PriceException : Exception
    {
        public PriceException() : base("Price must be greater or equal to zero")
        {
        }
    }
}
