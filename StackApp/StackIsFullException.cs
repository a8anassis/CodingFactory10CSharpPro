namespace StackApp;

internal class StackIsFullException : Exception
{
    public StackIsFullException() : base("Stack is full.") { }
    public StackIsFullException(string message) : base(message) { }
    public StackIsFullException(string message, Exception innerException) : base(message, innerException) { }
}
