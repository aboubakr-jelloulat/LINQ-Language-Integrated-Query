using _18_Converting_Data_Types.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Converting_Data_Types.AsEnumerable
{
    internal class clsAsEnumerable
    {
        public static void AsEnumerableMethode()
        {

            ShippingList<Shipping> shippings = ShippingRepository.AllAsShippingList;

            var todayShipping = shippings.Where(x => x.ShippingDate == DateTime.Today);

            todayShipping.Process("Today's shipping using ShippingList<T> Where");



            var todayShipping2 = shippings.AsEnumerable().Where(x => x.ShippingDate == DateTime.Today);

            todayShipping2.Process("Today's shipping using IEnumerable<T> Where");

        }

    }
}
