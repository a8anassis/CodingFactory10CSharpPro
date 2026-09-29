namespace IfUseCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            string? firstname = "John";

            if (age >= 18)
            {
                Console.WriteLine("Ενήλικας");
            }
            else
            {
                Console.WriteLine("Ανήλικος");
            }

            // Ternary operator for conditional assignment
            var status = (age >= 18) ? "Ενήλικας" : "Ανήλικος";
            Console.WriteLine($"Status: {status}");
          

            // Null-coalescing operator for default value assignment
            var name = firstname ?? "Unknown"; // (firstname is null) ? "Unknown" : firstname;

            // Null-conditional operator for safe member access
            var nameLength = firstname?.Length ?? 0; // (firstname is null) ? 0 : firstname.Length;
            Console.WriteLine($"Name Length: {nameLength}");
        }
    }
}
