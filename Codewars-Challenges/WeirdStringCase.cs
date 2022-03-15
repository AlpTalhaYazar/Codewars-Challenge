using System.Text;

namespace Codewars_Challenges;

public class WeirdStringCase
{
    public static string ToWeirdCase(string s)
    {
        StringBuilder builder = new();
    
        var shouldUpper = true;
    
        for (var i = 0; i < s.Length; i++)
        {
            var isAlphabetical = char.IsLetter(s[i]);
            if (isAlphabetical)
            {
                if (shouldUpper)
                    builder.Append(char.ToUpper(s[i]));
                else
                    builder.Append(char.ToLower(s[i]));
                
                shouldUpper = !shouldUpper;
            }
            else
            {
                builder.Append(s[i]);
                shouldUpper = true;
            }
        }
    
        return builder.ToString();
    }
    
    public static string ToWeirdCaseSecond(string s, bool shouldUpper = true)
    {
        return ToWeirdCaseSecondHelper(new StringBuilder(), s, true).ToString();
    }

    public static StringBuilder ToWeirdCaseSecondHelper(StringBuilder builder, string s, bool shouldUpper = true)
    {
        if (s.Length == 0)
            return builder;

        var isAlphabetical = char.IsLetter(s[0]);

        if (isAlphabetical)
        {
            if (shouldUpper)
                return ToWeirdCaseSecondHelper(builder.Append(s[0].ToString().ToUpper()), s[1..], false);

            return ToWeirdCaseSecondHelper(builder.Append(s[0].ToString().ToLower()), s[1..], true);
        }

        return ToWeirdCaseSecondHelper(builder.Append(s[0]), s[1..], true);
    }
}