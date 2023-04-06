namespace TradeCategorizer.Domain.Exceptions
{
    public class InvalidTradeException : Exception
    {
        public InvalidTradeException(string message) : base(message) { }
    }
}
