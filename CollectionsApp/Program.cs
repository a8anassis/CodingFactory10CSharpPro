using System.ComponentModel.DataAnnotations;

namespace CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // List - Populate a list using collection initializer syntax
            List<string> list = new() { "Hello", "World", "!" };   // Collection initializer syntax
            List<string> list2 = [ "Hello", "World", "!" ];           // C# 12.0 collection initializer syntax
            var list3 = new List<string> { "Hello", "World", "!" };   // C# 9.0 collection initializer syntax


            // HashSet - Populate a hashset using collection initializer syntax
            HashSet<string> set = new() { "Hello", "World", "!" };   // Collection initializer syntax
            HashSet<string> set2 = ["Hello", "World", "!"];           // C# 12.0 collection initializer syntax


            // Dictionary - Populate a dictionary using collection initializer syntax
            var dict = new Dictionary<int, string>
            {
                { 1, "Hello" },
                { 2, "World" },
                { 3, "!" },
            };

            var dict2 = new Dictionary<int, string>
            {
                [1] = "Hello",
                [2] = "World",
                [3] = "!",
            };

            // Queue - Populate a queue using collection initializer syntax
            Queue<string> queue = new Queue<string>(["Hello", "World", "!"]);

            // Stack - Populate a stack using collection initializer syntax
            Stack<int> stack = new Stack<int>([1, 2, 3]);
        }
    }
}
