using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Converting_Data_Types.Shared
{
    internal static class Extension
    {
        public static void Process<T>(this IEnumerable<T> source, string title) where T : Shipping
        {
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            foreach (var item in source)
            {
                ((Shipping)item).Start();
            }
        }

    }
}
