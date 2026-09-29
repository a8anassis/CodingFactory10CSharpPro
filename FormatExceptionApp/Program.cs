namespace FormatExceptionApp
{
    /// <summary>
    /// Διαβάζει ένα string από την κονσόλα και 
    /// προσπαθεί να το μετατρέψει σε ακέραιο αριθμό με Parse και
    /// θα ελέγξει με try-catch για FormatException.
    /// 
    /// Μην ξεχάσετε στη C# δεν υπάρχουν checked και unchecked exceptions όπως στη Java.
    /// Οπότε, δεν χρειάζεται να δηλώσετε throws FormatException στη μέθοδο Main.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Παρακαλώ εισάγετε έναν αριθμό:");
                    num = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Ο αριθμός που εισάγατε είναι: {num}");
                    if (num == 0) break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
