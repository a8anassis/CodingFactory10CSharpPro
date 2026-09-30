using System.Diagnostics;
using System.Text.RegularExpressions;
namespace RegExApp;

internal class Program
{
    static void Main(string[] args)
    {
        //string s = "I love coding";
        //TestMatch(s);

        string date = "12-30-2026";
        TestGroups(date);
    }

    public static bool TestStringPattern(string? s)
    {
        if (s == null) return false;
        
        string pattern = @"^coding$"; // verbatim match for the string "coding"
        bool isMatch = Regex.IsMatch(s, pattern);
        return isMatch;
    }

    public static void TestMatch(string? s)
    {
        if (s is null) return;
        string pattern = @"coding";
        Match match = Regex.Match(s, pattern);

        if (match.Success)
        {
            Console.WriteLine(match.Value);
        }
    }

    public static void TestMatches(string? s)
    {
        if (s is null) return;
        string pattern = @"\d+";

        MatchCollection matches = Regex.Matches(s, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    public static void TestGroups(string? s)
    {
        if (s is null) return;

        string pattern = @"(\d{2})-(\d{2})-(\d{4})";

        MatchCollection matches = Regex.Matches(s, pattern);

        foreach (Match match in matches)
        {
            for (int i = 1; i < match.Groups.Count; i++)
            {
                Console.WriteLine($"Group {i}: {match.Groups[i].Value}");
            }
        }
    }

    public static void MapToGrDate(string? s)
    {
        if (s is null) return;

        // MM-dd-yyyy (US format)
        string pattern = @"(\d{2})-(\d{2})-(\d{4})";

        MatchCollection matches = Regex.Matches(s, pattern);

        foreach (Match match in matches)
        {
            string month = match.Groups[1].Value;
            string day = match.Groups[2].Value;
            string year = match.Groups[3].Value;

            string grDate = $"{day}/{month}/{year}";
            Console.WriteLine($"{match.Value} -> {grDate}");
        }
    }

    // Zero-length assertions
    public static bool TestStrongPassword(string? s)
    {
        if (s is null) return false;
        return Regex.IsMatch(s, "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%^&*]).{12,}$");
    }
}
