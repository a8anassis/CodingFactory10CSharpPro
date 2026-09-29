namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before Swap: a = {a}, b = {b}");

            //Swap(a, b);
            SwapRef(ref a, ref b);
            Console.WriteLine($"After Swap: a = {a}, b = {b}");

        }

        /// <summary>
        /// Pass by value - does not swap the values of a and b in the calling method.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Swap(int a, int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static void SwapRef(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static (int, int) SwapWithTuple(int a, int b)
        {
            return (b, a);
        }
    }
}
