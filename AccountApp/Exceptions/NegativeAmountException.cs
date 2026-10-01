namespace AccountApp.Exceptions;

internal class NegativeAmountException : Exception
{
    public NegativeAmountException() : base("Negative amount is not allowed.")
    {
    }
    public NegativeAmountException(string message) : base(message)
    {
    }
    public NegativeAmountException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
