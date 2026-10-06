namespace StackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myStack = new CFStack(50);

            try
            {
                myStack.Push(10);
                myStack.Push(20);
                myStack.Push(30);

                Console.WriteLine($"Top item: {myStack.Peek(myStack.Count - 1)}");

                int poppedItem = myStack.Pop();
                Console.WriteLine($"Popped item: {poppedItem}");

                for (int i = 0; i < myStack.Count; i++)
                {
                    Console.WriteLine(myStack.Peek(i));
                }

            }
            catch (StackIsFullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (StackIsEmptyException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
