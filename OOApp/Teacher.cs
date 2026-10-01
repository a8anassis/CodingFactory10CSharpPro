
namespace OOApp;

/// <summary>
/// Defines a Teacher POCO class.
/// </summary>
internal class Teacher
{
    private int _id;
    private string? _firstname;
    private string? _lastname;

    public int Id { get => _id; set => _id = value; }       // expression-bodied property
    public string? Firstname { get => _firstname; set => _firstname = value; }
    public string? Lastname { get => _lastname; set => _lastname = value; }

    public Teacher()
    {
    }

    public Teacher(int id, string? firstname, string? lastname)
    {
        Id = id;
        Firstname = firstname;
        Lastname = lastname;
    }
}
