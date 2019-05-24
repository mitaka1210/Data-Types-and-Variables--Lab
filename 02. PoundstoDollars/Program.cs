using System;

namespace _02._PoundstoDollars
{
    class Program
    {
        static void Main(string[] args)
        {

            int pound = int.Parse(Console.ReadLine());

            double convertCurrency = pound * 1.31;
            Console.WriteLine($"{convertCurrency:f3}");
        }
    }
}
