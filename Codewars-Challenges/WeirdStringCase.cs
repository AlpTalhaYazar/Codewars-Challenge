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
}