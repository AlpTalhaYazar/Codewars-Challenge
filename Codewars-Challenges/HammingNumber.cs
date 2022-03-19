namespace Codewars_Challenges;

public class HammingNumber
{
    public static long Hamming(int n)
    {
        long two = 2, three = 3, five = 5;
        var h = new long[n];
        h[0] = 1;
        long x2 = 2, x3 = 3, x5 = 5;
        int i = 0, j = 0, k = 0;
    
        for (int index = 1; index < n; index++) 
        {
            h[index] = Math.Min(x2, Math.Min(x3, x5));
            if (h[index] == x2) x2 = two * h[++i];
            if (h[index] == x3) x3 = three * h[++j];
            if (h[index] == x5) x5 = five * h[++k];
        }
        return h[n - 1];
    }
}