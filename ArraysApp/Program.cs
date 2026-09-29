namespace ArraysApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 1;

            int[] arr2 = { 1, 2, 3, 4, 5 };

            int[] arr3;
            arr3 = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            foreach (var num in arr2)
            {
                Console.WriteLine(num);
            }


        }
    }
}
