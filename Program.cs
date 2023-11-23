namespace Tmp;

public class Program
{
    private static void Main()
    {
        string fullInput = "", input;

        for (; !string.IsNullOrWhiteSpace((input = Console.ReadLine() ?? string.Empty)); fullInput += $"{input} ") ;

        Console.WriteLine(fullInput);
    }
}
