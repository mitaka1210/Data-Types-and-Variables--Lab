using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int upBorder = int.Parse(Console.ReadLine());

            for (int i = 1; i <= upBorder; i++)

            {

                int current = i;

                int sum = 0;

                while (current > 0)

                {

                    sum += current % 10;

                    current /= 10;

                }

                bool magicDigit = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine($"{i} -> {magicDigit}");

            } // end for

        }
    }
}
