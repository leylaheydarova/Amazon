namespace Amazon.Exceptions.NotFoundExceptions
{
    public class NotFoundException : Exception
    {

        public NotFoundException(string? message) : base($"{message} was not found!")
        {
        }
    }
}
