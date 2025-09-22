using System;
using System.Collections.Generic;
using System.Text;

namespace _15__Sets_Operations.Shared
{
    public static class Extensions
    {

        public static void Print<T>(this IEnumerable<T> source, string title)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{title}\n");
            Console.ForegroundColor = defaultColor;

            foreach (var item in source)
                Console.WriteLine($"{item}");
        }
    }
}