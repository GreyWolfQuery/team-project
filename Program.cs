namespace Tmp;

public class Program
{
    private static void Main()
    {
        while (true)
        {
            Console.WriteLine("Co Chceš spustit: \n" + "VypisVetu\n" + "VypisPetkrat\n" + "OpakujInput\n" + "Ondra\n" + "Zadej: ");
            string? Input = Console.ReadLine();

            if (Input == "VypisVetu")
            {
                VypisVetu();
                Console.ReadKey();
                Console.Clear();
            }
            else if (Input == "VypisPetkrat")
            {
                VypisPetkrat();
                Console.ReadKey();
                Console.Clear();
            }
            else if (Input == "OpakujInput")
            {
                OpakujInput();
                Console.ReadKey();
                Console.Clear();
            }
            else if (Input == "Ondra")
            {
                Ondra();
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Errr!!!");
            }
        }
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
        Console.Write("Zadej prvni slovo: ");
        string fullInput = string.Empty;
        for (string input; !string.IsNullOrWhiteSpace((input = Console.ReadLine() ?? string.Empty)); fullInput += $"{input} ") ;
        Console.WriteLine(fullInput);
    }

    private static void Ondra()
    {
        Console.WriteLine("To jsem ja ondra!! ");
    }
    private static void Kacka()
    {
        Console.WriteLine("To jsem ja kacka!! ");
    }

    private static void Jirka()
    {
        Console.WriteLine("Nažďar!");
    }
    private static void Oskar()
    {
        Console.WriteLine("David je noob!");
    }
    private static void David()
    {
        Console.WriteLine("Oskare umri!");
    }
<<<<<<< HEAD
    private static void Simon()
    {
        Console.WriteLine("Nechci být doma :(");
=======
    private static void Sam()
    {
        Console.WriteLine("Mam deti ve sklepe!");
>>>>>>> 06f997ff3d81a65c93d478582ba1a6f2c9756c0b
    }
}

