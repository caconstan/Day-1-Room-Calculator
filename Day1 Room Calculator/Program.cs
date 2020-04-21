using System;

namespace Day1_Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyToCheck = "Y";
            ConsoleKeyInfo cki;

            do {
                Console.WriteLine("\n\nWelcome to the Grand Circus Room Detail Generator!\n");
                Console.Write("Enter Length: ");
                decimal length = decimal.Parse(Console.ReadLine());

                Console.Write("Enter Width: ");
                decimal width = decimal.Parse(Console.ReadLine());

                Console.Write("Enter Height: ");
                decimal height = decimal.Parse(Console.ReadLine());

                decimal area = length * width;
                decimal perimeter = 2 * length + 2 * width;
                decimal volume = area * height;

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                Console.Write("Continue? (y/n)");
                cki = Console.ReadKey();

            } while (keyToCheck.Equals(cki.Key.ToString()));
        }
    }
}
