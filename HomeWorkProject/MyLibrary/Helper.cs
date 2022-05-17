using System;

namespace MyLibrary
{
    public static class Helper
    {
        /// <summary>
        /// This is method to print out colored string
        /// </summary>
        /// <param name="str">string parameter</param>
        /// <param name="color">color to display</param>
        /// <exception cref="NullReferenceException"></exception>
        public static void PrintWithColor(string str, ConsoleColor color = ConsoleColor.DarkGray)
        {
            if (str == null)
                throw new NullReferenceException("String should contain something");

            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ResetColor();
        }
    }
}
