using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int number1 = number;
            int years = number1 * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            Console.WriteLine($"{number} centuries = {years:F0} years = {days:F0} days = {hours:F0} hours = {minutes:f0} minutes");
            
        }
    }
}
