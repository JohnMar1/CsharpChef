using System;
using System.Text;
class Program
{
    static string invalid = "Invalidní možnost...";

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Co chcete dneska dělat:");
            Console.WriteLine("1. Zakódovat");
            Console.WriteLine("2. Dekódovat");
            Console.WriteLine("3. Konec");
            Console.Write("Vyberte možnost: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Clear();
                Console.WriteLine(invalid);
                continue;
            }

            switch (choice)
            {
                case 1:
                    EncodeMenu();
                    break;
                case 2:
                    DecodeMenu();
                    break;
                case 3:
                    Console.WriteLine("Ukončuji program...");
                    return;
                default:
                    Console.WriteLine(invalid);
                    break;
            }
        }
    }
    static void EncodeMenu()
    {
        string prompt = "Napište string pro zakódování: ";
        Console.Clear();
        Console.WriteLine("Jak chcete zakódovat:");
        Console.WriteLine("1. Base64");
        Console.WriteLine("2. Binary");
        Console.WriteLine("3. Hex");
        Console.Write("Vyberte možnost: ");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.Clear();
            Console.WriteLine(invalid);
            return;
        }
        Console.Clear();
        switch (choice)
        {
            default:
                Console.WriteLine(" .");
                break;
        }
    }

    static void DecodeMenu()
    {
        string prompt = "Napište string pro dekódování: ";
        Console.Clear();
        Console.WriteLine("Jak chcete dekódovat:");
        Console.WriteLine("1. Base64");
        Console.WriteLine("2. Binary");
        Console.WriteLine("3. Hex");
        Console.Write("Vyberte možnost: ");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine(invalid);
            return;
        }
        Console.Clear();
        switch (choice)
        {

            default:
                Console.WriteLine(invalid);
                break;
        }
    }
}