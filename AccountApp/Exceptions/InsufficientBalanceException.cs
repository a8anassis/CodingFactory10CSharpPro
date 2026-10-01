namespace AccountApp.Exceptions;

internal class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException() : base("Insufficient balance for the requested transaction.")
    {
    }

    public InsufficientBalanceException(string message) : base(message)
    {
    }

    public InsufficientBalanceException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
