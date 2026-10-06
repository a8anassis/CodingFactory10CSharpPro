using System.Text;

namespace FileManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\tmp\file.txt";
            DLList<char> dll = new();

            try
            {
                using StreamReader reader = new StreamReader(filePath, Encoding.UTF8);

                int ordinal;
                while ((ordinal = reader.Read()) != -1)
                {
                    char ch = (char)ordinal;
                    if (ch is '\r' or '\n') continue; // Skip new line characters)
                    dll.UpSert(ch);
                }

                //dll.SortByCount();
                dll.SortByValue();
                dll.PrintList();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found: {filePath}");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Access denied to file: {filePath}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"I/O Error: {ex.Message}");
            }
        }
    }
}
