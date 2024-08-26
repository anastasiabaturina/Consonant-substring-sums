namespace ConsonantSubstringSums;

public class SubstringSumReader
{
    public static int CalculateSumSubstring(string str)
    {
        var sum = 0;
        var allSum = new List<int>();

        for (var i = 0; i < str.Length; i++)
        {
            if (str[i] != 'a' && str[i] != 'e' && str[i] != 'i' && str[i] != 'o' && str[i] != 'u')
            {
                sum += str[i] - 96;
                allSum.Add(sum);
            }
            else
            {
                sum = 0;
            }
        }

        return allSum.Max();
    }
}