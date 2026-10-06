namespace LinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = [1, 2, 3, 4, 5];

            // LINQ query to filter even numbers
            IEnumerable<int> allNumbers = from num in numbers
                                            select num;

            foreach (var num in allNumbers)
            {
                Console.WriteLine(num);
            }

            // LINQ query to filter even numbers
            var evenNumbers = (from num in numbers
                               where num % 2 == 0
                               select num).ToList();

         
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }


            // Mapping: LINQ query to square each number
            var squaredNumbers = (from num in numbers
                                  select num * num).ToList();


            var list = new List<int> { 5, 3, 8, 3, 1 };
            var set = new HashSet<int> { 5, 3, 8, 1 };
            var grades = new Dictionary<string, int>
            {
                ["Alice"] = 45,
                ["Bob"] = 90,
                ["maria"] = 78,
                ["John"] = 95
            };

            // Method syntax: LINQ query to filter even numbers

            // filtering
            var evenNumbers2 = numbers.Where(num => num % 2 == 0).ToList();
            var sortedSet = set.OrderBy(num => num).ToList();


            // Map
            var squares = set.Select(num => num * num).ToHashSet();
            var evenSquares = set.Where(num => num % 2 == 0).Select(num => num * num).ToHashSet();

            var passed = grades.Where(kv => kv.Value >= 50).Select(kv => kv.Key).ToList();
            var top = grades.Where(kv => kv.Value >= 80).OrderByDescending(kv => kv.Value).ToDictionary(kv => kv.Key, kv => kv.Value);

            // Reduction
            var avg = grades.Values.Average();
            var minNum = numbers.Min();
            var maxNum = numbers.Max();
            var countNums = numbers.Count();


            // Aggregation
            bool allPassed = grades.All(kv => kv.Value >= 50);
            bool anyPassed = grades.Any(kv => kv.Value >= 50);


        }
    }
}
