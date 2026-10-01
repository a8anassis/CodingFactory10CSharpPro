namespace OOApp;

/// <summary>
/// Defines a StudentInsertDTO record class.
/// Public init-only properties for Firstname and Lastname.
/// Primary constructor to initialize the properties.
/// Value-based equality with == and != operators.
/// ToString() method for string representation.
/// </summary>
/// <param name="Firstname"></param>
/// <param name="Lastname"></param>
internal record StudentInsertDTO(string? Firstname, string? Lastname)
{
}
