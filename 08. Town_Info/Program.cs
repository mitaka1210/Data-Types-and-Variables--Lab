﻿using System;

namespace _08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {

            string townName = Console.ReadLine();

            int cityPopulation = int.Parse(Console.ReadLine());

            int area = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {cityPopulation} and area {area} square km.");
        }
    }
}

//"Town {town name} has population of {population} and area {area} square km".