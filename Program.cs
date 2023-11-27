﻿namespace Tmp;

public class Program
{
    private static void Main()
    {
        VypisVetu();
        Console.ReadKey();
        Console.Clear();

        VypisPetkrat();
        Console.ReadKey();
        Console.Clear();

        OpakujInput();
    }

    public static void OpakujInput()
    {
        for (int count = 1; ; ++count)
        {
            string input;
            do Console.Write("Zadej slovo: ");
            while (string.IsNullOrWhiteSpace((input = Console.ReadLine() ?? string.Empty)));
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
        Console.WriteLine("konec");
    }

    public static void VypisVetu()
    {
        string fullInput = string.Empty;
        for (string input; !string.IsNullOrWhiteSpace((input = Console.ReadLine() ?? string.Empty)); fullInput += $"{input} ") ;
        Console.WriteLine(fullInput);
    }
}

