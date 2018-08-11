using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeMarket.Interfaces;

namespace TradeMarket.Model
{
    public class Order : IOrder
    {
        public Order(OrderType type, OrderState  state, decimal price, int quantity)
        {

        }

        //todo: think if realy need..      
         public int ID { get; private set; }


        public OrderType Type { get; private set; }
        public OrderState State { get; set; }

        public decimal Price { get; private set; }

        public int Quantity { get; private set; }
    }
}
