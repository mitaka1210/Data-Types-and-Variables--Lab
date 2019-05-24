/*Write program to enter n numbers and calculate and print their
 exact sum (without rounding).
 ____________________________________________________________
 INPUT                                    OUTPUT
 3                                        1000000000000000015
 1000000000000000000
 5
 10
 ____________________________________________________________
 2                                        333333333333.30000000003
 0.00000000003
 333333333333.3
 ____________________________________________________________
 Hints: Use BigInteger to not lose precision.
 */
using System;
using System.Numerics;



namespace _03ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)

        {
            int numCount = int.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int i = 0; i < numCount; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}