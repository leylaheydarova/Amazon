namespace Amazon.Extensions
{
    public static class PriceExtension
    {
        public static bool IsGreaterThanZero(this double price)
        {
            return price >= 0;
        }
    }
}


