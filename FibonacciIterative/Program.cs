namespace FibonacciIterative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Fibonacci(10) = {FibonacciRecursive(0)}");
        }

        /// <summary>
        /// Calculates the nth Fibonacci number.
        /// </summary>
        /// <remarks>The method uses an iterative approach.</remarks>  
        /// <param name="n">The position in the Fibonacci sequence</param>
        /// <returns>The nth Fibonacci number. Returns 0 for n <= 0 and 1 for n == 1.</returns>
        public static int Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            int a = 0;
            int b = 1;
            int c = 1;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        /// <summary>
        /// Calculates the n-th Fibonacci number.
        /// </summary>
        /// <remarks>This method uses an array to store intermediate Fibo numbers.</remarks>
        /// <param name="n">The zero-based index of the Fibonacci number.</param>
        /// <returns>The Fibonacci number at the specified index.</returns>
        public static int FibonacciWithArray(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            int[] arr = new int[n + 1];

            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[n];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FibonacciRecursive(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}
