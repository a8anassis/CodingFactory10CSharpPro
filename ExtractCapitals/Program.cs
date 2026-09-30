using System.Text;
namespace ExtractCapitals;

internal class Program
{
    static void Main(string[] args)
    {
        string? s = "CoDinG";
        string capitals = ExtractCapitals(s);
        Console.WriteLine($"{s} -> {capitals}");
    }

    public static string ExtractCapitals(string? s)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < s?.Length; i++)
        {
            char c = s[i];
            if (char.IsUpper(c))
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}
