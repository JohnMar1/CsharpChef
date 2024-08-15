using System;
using System.Text;
class Program
{
    static string invalid = "Invalid option...";
    public class Binary
    {
        public static string Encode(string input)
        {
            string result = "";
            foreach (char c in input)
            {
                result += Convert.ToString(c, 2).PadLeft(8, '0');
            }
            return result;
        }

        public static string Decode(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i += 8)
            {
                string byteString = input.Substring(i, 8);
                result += (char)Convert.ToByte(byteString, 2);
            }
            return result;
        }
    }
    public class Base64
    {
        public static string Encode(string input)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
        }

        public static string Decode(string input)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(input));
        }
    }
    public class Hex
    {
        public static string Encode(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            return BitConverter.ToString(bytes).Replace("-", "");
        }
        public static string Decode(string input)
        {
            byte[] bytes = new byte[input.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(input.Substring(i * 2, 2), 16);
            }
            return Encoding.UTF8.GetString(bytes);
        }
    }
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("What do you want to do today:");
            Console.WriteLine("1. Encode");
            Console.WriteLine("2. Decode");
            Console.WriteLine("3. Quit");
            Console.Write("Select option: ");

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
                    Console.WriteLine("Quitting program...");
                    return;
                default:
                    Console.WriteLine(invalid);
                    break;
            }
        }
    }
    static void EncodeMenu()
    {
        string prompt = "Enter string for encoding: ";
        Console.Clear();
        Console.WriteLine("How do you want to encode:");
        Console.WriteLine("1. Base64");
        Console.WriteLine("2. Binary");
        Console.WriteLine("3. Hex");
        Console.Write("Select option: ");

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
            case 1:
                Console.Write(prompt);
                Console.WriteLine(Base64.Encode(Console.ReadLine()));
                break;
            case 2:
                Console.Write(prompt);
                Console.WriteLine(Binary.Encode(Console.ReadLine()));
                break;
            case 3:
                Console.Write(prompt);
                Console.WriteLine(Hex.Encode(Console.ReadLine()));
                break;
            default:
                Console.WriteLine(" .");
                break;
        }
    }

    static void DecodeMenu()
    {
        string prompt = "Enter string for decoding: ";
        Console.Clear();
        Console.WriteLine("How do you want to decode:");
        Console.WriteLine("1. Base64");
        Console.WriteLine("2. Binary");
        Console.WriteLine("3. Hex");
        Console.Write("Select option: ");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine(invalid);
            return;
        }
        Console.Clear();
        switch (choice)
        {
            case 1:
                Console.Write(prompt);
                Console.WriteLine(Base64.Decode(Console.ReadLine()));
                break;
            case 2:
                Console.Write(prompt);
                Console.WriteLine(Binary.Decode(Console.ReadLine()));
                break;
            case 3:
                Console.Write(prompt);
                Console.WriteLine(Hex.Decode(Console.ReadLine()));
                break;
            default:
                Console.WriteLine(invalid);
                break;
        }
    }
}