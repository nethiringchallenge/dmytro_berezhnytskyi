using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeMarket.Interfaces;

namespace TradeMarket
{
    public class OrdersStorage
    {
        private List<IOrder> orders;
        private OrdersStorage()
        {
            orders = new List<IOrder>();
        }

        private static readonly OrdersStorage ordersStorage = new OrdersStorage();

        public static OrdersStorage GetOrdersStorage()
        {
            return ordersStorage;
        }

        public void AddOrder(IOrder order)
        {
            orders.Add(order);
        }
        
    }
}
