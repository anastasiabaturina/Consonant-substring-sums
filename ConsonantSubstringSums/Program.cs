namespace ConsonantSubstringSums;

public class Program
{
    public static void Main()
    {
        var example1 = SubstringSumReader.CalculateSumSubstring("zodiacs");
        var example2 = SubstringSumReader.CalculateSumSubstring("strength");

        Console.WriteLine(example1);
        Console.WriteLine(example2);
    }
}