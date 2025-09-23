using _18_Converting_Data_Types.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Converting_Data_Types.OfType
{
    internal class clsOfType
    {

        public static void OfTypeMethode()
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

            var groundShippings = shippings.OfType<GroundShipping>();

            groundShippings.Process("Ground shippings");


        }

    }


    public static class SampleExtension
    {
        public static IEnumerable<T> Cast<T>(this IEnumerable<T> source)
        {
            foreach (var item in source)
            {
                if (item is T)
                    yield return (T)item;
            }

        }

    }

}
