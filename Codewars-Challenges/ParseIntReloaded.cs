using System.Text.RegularExpressions;

namespace Codewars_Challenges;

public class ParseIntReloaded
{
    private static Dictionary<string, int> _numberTable = new()
    {
        { "zero", 0 },
        { "one", 1 },
        { "two", 2 },
        { "three", 3 },
        { "four", 4 },
        { "five", 5 },
        { "six", 6 },
        { "seven", 7 },
        { "eight", 8 },
        { "nine", 9 },
        { "ten", 10 },
        { "eleven", 11 },
        { "twelve", 12 },
        { "thirteen", 13 },
        { "fourteen", 14 },
        { "fifteen", 15 },
        { "sixteen", 16 },
        { "seventeen", 17 },
        { "eighteen", 18 },
        { "nineteen", 19 },
        { "twenty", 20 },
        { "thirty", 30 },
        { "forty", 40 },
        { "fifty", 50 },
        { "sixty", 60 },
        { "seventy", 70 },
        { "eighty", 80 },
        { "ninety", 90 },
        { "hundred", 100 },
        { "thousand", 1000 },
        { "million", 1000000 }
    };

    public static int ParseInt(string input)
    {
        var numbers = Regex.Matches(input, @"\w+")
            .Select(m => m.Value.ToLowerInvariant())
            .Where(v => _numberTable.ContainsKey(v))
            .Select(v => _numberTable[v]);
        int acc = 0, total = 0;
        foreach (var n in numbers)
        {
            total += n >= 1000 ? (acc * n) : 0;
            acc = n >= 1000 ? 0 : n >= 100 ? acc * n : acc + n;
        }

        return (total + acc) * (input.StartsWith("minus",
            StringComparison.InvariantCultureIgnoreCase)
            ? -1
            : 1);
    }
}