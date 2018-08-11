using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeMarket.Helper
{
    public static class Guard
    {
        public static void ArrayItemsEquals(object[] arr, int count)
        {
            if (arr.Count() != count)
            {
                //TODO : custom exeption
                throw new ArgumentException();
            }
        }

        public static void GreaterThanZero(int value)
        {
            if (value < 0)
            {
                //TODO : custom exeption
                throw new ArgumentException();
            }
        }
    }
}
