using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();

            if (name == "A" || name == "B"|| name=="C" || name=="D" ||
                 name == "E" || name == "F" || name == "G" || name == "H" && name == "I" || name == "K" || name == "L" || name == "M" || name == "N" || name == "O"|| name == "P" || name == "Q" || name == "R" || name == "S" || name == "T" || name == "V" || name == "U" || name == "W" || name == "X" || name == "Y" || name == "Z")
               // E F G H I K L M N O P Q R S T V X Y Z
            {
                Console.WriteLine("upper-case");
            }
            else if (name == "a" || name == "b"|| name=="c" || name=="d" ||
                 name == "e" || name == "f" || name == "g" || name == "h" && name == "i" || name == "k" || name == "l" || name == "m" || name == "n" || name == "o"|| name == "p" || name == "q" || name == "r" || name == "s" || name == "t" || name == "v" || name == "u" || name == "w" || name == "x" || name == "y" || name == "z")

            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
