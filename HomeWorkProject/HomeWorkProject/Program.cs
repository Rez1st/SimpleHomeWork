using System;

namespace HomeWorkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintWithColor(Calc.Add(1,2).ToString(), ConsoleColor.DarkMagenta);
            PrintWithColor(Calc.Add(1,1321321).ToString());
        }


        /// <summary>
        /// This is method to print out colored string
        /// </summary>
        /// <param name="str">string parameter</param>
        /// <param name="color">color to display</param>
        static void PrintWithColor(string str, ConsoleColor color = ConsoleColor.DarkGray)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ResetColor();
        }
    }
}
