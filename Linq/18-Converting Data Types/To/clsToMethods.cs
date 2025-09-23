using _18_Converting_Data_Types.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Converting_Data_Types.To
{
    internal class clsToMethods
    {
        public static void ToMethods()
        {
            // ToArray();

            // ToList();

            // ToDictionary();

            ToLookup();

        }



        public static void ToLookup()
        {

            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

            ILookup<string, Shipping> lookup1 = shippings.ToLookup(x => x.UniqueId);
            lookup1["ABC005"].First().Start();

            ILookup<DateTime, Shipping> lookup2 = shippings.ToLookup(x => x.ShippingDate);

            var date = new DateTime(2022, 3, 9, 0, 0, 0);
            lookup2[date].Process($"Shippings on {date.ToString("dddd, MMMM dd yyyy")}");

        }

        public static void ToDictionary()
        {

            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

            Dictionary<string, Shipping> dictionary1 = shippings.ToDictionary(x => x.UniqueId);
            dictionary1["ABC005"].Start();

            Dictionary<DateTime, List<Shipping>> dictionary2 = shippings.GroupBy(x => x.ShippingDate)
                .ToDictionary(s => s.Key, s => s.ToList());

            var date = new DateTime(2022, 3, 9, 0, 0, 0);
            dictionary2[date].Process($"Shippings on {date.ToString("dddd, MMMM dd yyyy")}");

        }

        static void ToArray()
        {

            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

            var shippingArray = shippings.ToArray(); // convert to array 

            Console.WriteLine($"total shippings: {shippingArray.Length}");

            Console.WriteLine($"first shipping");

            shippingArray[0].Start();

        }

        static void ToList()
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

            List<Shipping> shippingList = shippings.ToList();

            Console.WriteLine($"total shippings: {shippingList.Count}");
            Console.WriteLine($"first shipping");
            shippingList[0].Start();

            shippingList.First().Start(); // same 

        }


    }
}
