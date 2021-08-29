using System;

namespace ConsoleApp_color_scheme_activity
{

    class Program
    {
        static void Main(string[] args)
        {
            string c1, c2;
            Console.Write("Enter the 1st color : ");
            c1 = Console.ReadLine();
            Console.Write("Enter the 2nd color : ");
            c2 = Console.ReadLine();
            if((c1=="RED" && c2=="GREEN")||(c1=="GREEN" && c2=="RED"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Replace with Yellow");


            }
            else if ((c1 == "RED" && c2 == "BLUE") || (c1 == "BLUE" && c2 == "RED"))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Replace with magenta");

            }
            else if ((c1 == "GREEN" && c2 == "BLUE") || (c1 == "BLUE" && c2 == "GREEN"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Replace with Cyan");

            }
            else
            {
                Console.WriteLine("color entered is incorrect");
            }
        }
    }
}
