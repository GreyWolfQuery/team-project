namespace Tmp;

public class Program
{
    private static void Main()
    {
        VypisVetu();
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

    public static void VypisVetu()
    {
        string fullInput = "";
        for (string input; !string.IsNullOrWhiteSpace((input = Console.ReadLine() ?? string.Empty)); fullInput += $"{input} ") ;
        Console.WriteLine(fullInput);
    }
}
