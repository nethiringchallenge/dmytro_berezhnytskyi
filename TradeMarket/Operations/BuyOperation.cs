using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeMarket.Helper;

namespace TradeMarket.Operations
{
    class BuyOperation : BaseOperation, IOperation
    {
        public void Execute(string[] arr)
        {
            Guard.ArrayItemsEquals(arr, 3);

            decimal price = 0;
            if (!decimal.TryParse(arr[1], out price))
            {
                throw new ArgumentException();
            }

            var quantity = 0;
            if (!int.TryParse(arr[2], out quantity))
            {
                throw new ArgumentException();
            }
            var order = new Order()

        }
    }
}   
