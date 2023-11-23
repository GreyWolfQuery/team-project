namespace Tmp;

public class Program
{
    private static void Main()
    {
        Console.WriteLine(ZiskejVetu());
        VypisPetkrat();
        OpakujInput();
    }

    public static void OpakujInput()
    {
        int count = 1;
        for (;;++count)
        {
            string input;
            do
            {
                Console.Write("Zadej slovo: ");
            } while (string.IsNullOrWhiteSpace((input = Console.ReadLine() ?? string.Empty)));

            for (int i = 1; i <= count; ++i)
                Console.WriteLine($"{i}. {input}");
        }
    }

    public static void VypisPetkrat()
    {
        string input;
        do
        {
            Console.Write("Zadej slovo: ");
        } while (string.IsNullOrWhiteSpace((input = Console.ReadLine() ?? string.Empty)));

        for (int i = 1; i <= 5; ++i)
            Console.WriteLine($"{i}. {input}");
    }

    public static string ZiskejVetu()
    {
        string fullInput = "";
        for (string input; !string.IsNullOrWhiteSpace((input = Console.ReadLine() ?? string.Empty)); fullInput += $"{input} ") ;
        return fullInput;
    }
}
