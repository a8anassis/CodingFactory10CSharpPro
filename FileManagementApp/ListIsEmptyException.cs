namespace FileManagementApp;

internal class ListIsEmptyException : Exception
{
    public ListIsEmptyException() : base("List is empty.") { }
    public ListIsEmptyException(string message) : base(message) { }
    public ListIsEmptyException(string message, Exception innerException) : base(message, innerException) { }
}
