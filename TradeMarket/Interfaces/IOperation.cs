using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeMarket
{
    public interface IOperation
    {
        void Execute(string[] parameters);
    }
}
