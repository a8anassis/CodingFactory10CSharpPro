namespace WhileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int END = 3;
            int sum = 0;
            int i = 0;

            while (i < END)
            {
                sum += i;
                i++;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
