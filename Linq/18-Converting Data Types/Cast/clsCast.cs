using _18_Converting_Data_Types.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Converting_Data_Types.Cast
{
    internal class clsCast
    {
        public static void CastMethode()
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

            var groundShippings = shippings.Where(x => x.GetType() == typeof(GroundShipping)).Cast<GroundShipping>();

            groundShippings.Process("Ground shippings");

        }
    }
}
