namespace DoWhileApp
{
    /// <summary>
    /// Counts the number of digits.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int numberOfDigits = 0;
            int tmp = 0;

            Console.WriteLine("Παρακαλώ εισάγετε έναν αριθμό:");
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Μη έγκυρη είσοδος. Παρακαλώ εισάγετε έναν ακέραιο αριθμό.");
                return;
            }

            tmp = num;
            do
            {
                tmp /= 10;
                numberOfDigits++;
            } while (tmp != 0);
            Console.WriteLine($"Ο αριθμός {num} έχει {numberOfDigits} ψηφία.");
        }
    }
}
