namespace OOApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User alice = new User();
            User bob = new();           // C# 9.0
            var charlie = new User();   // C# 10.0

            Teacher teacher = new Teacher();
            Teacher teacher2 = new();    // C# 9.0
            var teacher3 = new Teacher();  // C# 10.0
            Teacher teacher4 = new Teacher(1, "John", "Doe");
            Teacher teacher5 = new() { Id = 2, Firstname = "Jane", Lastname = "Smith" }; // C# 9.0 object initializer syntax


            User dimis = new User()     // Object initializer syntax
            {
                Id = 1,
                Username = "dimis",
                Email = "dimis@gmail.com"
            };

            alice.Id = 1;                       // setters
            alice.Username = "alice";           // setters
            alice.Email = "alice@gmail.com";    // setters

            Console.WriteLine($"Alice: {alice.Id} {alice.Username} ({alice.Email})");    // getters
            Console.WriteLine($"Dimis: {dimis.Id} {dimis.Username} ({dimis.Email})");   // getters
        }
    }
}
