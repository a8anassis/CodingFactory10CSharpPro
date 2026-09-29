namespace PyramidChallenge
{
    /// <summary>
    /// Ο χρήστης εισάγει το ύψος της πυραμίδας 
    /// και το πρόγραμμα εμφανίζει την πυραμίδα με αστεράκια.
    /// Για παράδειγμα, αν ο χρήστης εισάγει 5, η έξοδος θα είναι:
    ///     *
    ///    ***
    ///   *****
    ///  *******
    /// *********
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the pyramid:");
            int height = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= height; i++)
            {
                // Print spaces
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                // Print asterisks
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                // Move to the next line
                Console.WriteLine();
            }
        }
    }
}
