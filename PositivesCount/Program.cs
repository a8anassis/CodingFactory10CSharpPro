namespace PositivesCount
{
    /// <summary>
    /// Μετράει το πλήθος των θετικών αριθμών που εισάγει 
    /// ο χρήστης μέχρι να εισάγει το 0.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Παρακαλώ εισάγετε έναν αριθμό:");

            while (int.TryParse(Console.ReadLine(), out int num) && num != 0)
            {
                if (num > 0) count++;
                Console.WriteLine("Παρακαλώ εισάγετε έναν αριθμό:");
            }
            Console.WriteLine($"Πλήθος θετικών αριθμών: {count}");
        }
    }
}
