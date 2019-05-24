using System;

namespace Data_Types_and_Variables___Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            double result = number * 0.001;
            Console.WriteLine($"{result:f2}");
        }
    }
}
