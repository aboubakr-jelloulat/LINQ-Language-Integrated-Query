using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Converting_Data_Types.Shared
{
    public class ShippingList<T> : List<T> where T : Shipping
    {
        public IEnumerable<T> Where(Func<T, bool> predicate)
        {
            Console.WriteLine("filtering shipping ...");
            return Enumerable.Where(this, predicate);
        }
    }
}
