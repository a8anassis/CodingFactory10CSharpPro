namespace LinqArrays
{
    /// <summary>
    /// LINQ (Language Integrated Query) is a powerful feature in C# 
    /// that allows you to query and manipulate data from various sources, 
    /// including arrays, collections, databases, and more. 
    /// In this example, we will demonstrate how to use LINQ methods to perform 
    /// common operations on an array of integers.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 9, 2, 12 };

            int min = arr.Min();
            int max = arr.Max();
            int sum = arr.Sum();
            double average = arr.Average();
            int count = arr.Count();                        // int count = arr.Length; // This is also valid
            int countFT4 = arr.Count(x => x > 4);           // Count elements greater than 4

            var filtered = arr.Where(x => x > 4).ToArray();         // Filter elements greater than 4
            var doubled = arr.Select(x => x * 2).ToArray();        // Map each element to its double
            var sorted = arr.OrderBy(x => x).ToArray();               // Sort the array in ascending order
            var sortedDesc = arr.OrderByDescending(x => x).ToArray();               // Sort the array in descending order
            bool any = arr.Any(x => x > 10);                       // Check if any element is greater than 10
            bool all = arr.All(x => x > 0);                        // Check if all elements are greater than 0
            int first = arr.First(x => x > 4);                     // Get the first element greater than 4
        }
    }
}
