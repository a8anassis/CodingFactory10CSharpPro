namespace CollectionsApp;

internal class Program
{
    static void Main(string[] args)
    {

        // List - Populate a list using collection initializer syntax
        List<string> list = new() { "Hello", "World", "!" };   // Collection initializer syntax
        List<string> list2 = ["Hello", "World", "!"];           // C# 12.0 collection initializer syntax
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

        // List API

    }

    public static void ListAPI(List<string> list)
    {
        list.Add("Coding");
        list.AddRange(["Factory", "AUEB"]);
        list.Insert(1, "is");
        list.Remove("AUEB");
        list.RemoveAt(0);

        list[1] = "awesome";            // Update
        string token = list[1];         // Read
        Console.WriteLine($"List Count: {list.Count}");

        list.ForEach(item => Console.WriteLine(item));
    }

    public static void LinkedListAPI(LinkedList<string> linkedList)
    {
        linkedList.AddLast("Hello");
        linkedList.AddLast("World");
        linkedList.AddFirst("!");
        linkedList.AddAfter(linkedList.First!, "Coding");
        linkedList.AddBefore(linkedList.Last!, "Factory");
        linkedList.RemoveFirst();
        linkedList.RemoveLast();
        Console.WriteLine($"LinkedList Count: {linkedList.Count}");

        foreach (var item in linkedList)
        {
            Console.WriteLine(item);
        }
    }

    public static void HashSetAPI(HashSet<string> hashSet1)
    {
        var hashSet2 = new HashSet<string>(["Hello", "World", "Factory"]);
        hashSet1.Add("Hello");
        hashSet1.Add("World");
        hashSet1.Add("!");
        hashSet1.Remove("World");
        Console.WriteLine($"HashSet Count: {hashSet1.Count}");

        hashSet1.IntersectWith(hashSet2);        // Keep only elements that are also in set2

        foreach (var item in hashSet1)
        {
            Console.WriteLine(item);
        }
    }

    public static void DictionaryAPI(Dictionary<string, int> dict)
    {
        dict.Add("Hello", 1);
        dict["World"] = 2;          // Insert or update
        dict.Remove("Hello");
        Console.WriteLine($"Dictionary Count: {dict.Count}");

        if (!dict.TryGetValue("Hello", out int value))
        {
            Console.WriteLine("Key not found.");
        }

        foreach (var kvp in dict)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }

    /// <summary>
    /// FIFO - First In First Out structure. 
    /// The first element added to the queue will be the first one to be removed.
    /// </summary>
    /// <param name="queue"></param>
    public static void QueueAPI(Queue<string> queue)
    {
        queue.Enqueue("Hello");
        queue.Enqueue("World");
        queue.Enqueue("!");
        string first = queue.Dequeue();

        Console.WriteLine($"Dequeued: {first}");
        Console.WriteLine($"Queue Count: {queue.Count}");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }

    /// <summary>
    /// LIFO - Last In First Out structure.
    /// The last element added to the stack will be the first one to be removed.
    /// </summary>
    /// <param name="stack"></param>
    public static void StackAPI(Stack<int> stack)
    {
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        int top = stack.Pop();

        Console.WriteLine($"Popped: {top}");
        Console.WriteLine($"Stack Count: {stack.Count}");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }


}
