namespace AccountApp.Exceptions;

internal class InvalidSsnException : Exception
{
    public InvalidSsnException() : base("Invalid SSN provided.")
    {
    }
    public InvalidSsnException(string message) : base(message)
    {
    }
    public InvalidSsnException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
