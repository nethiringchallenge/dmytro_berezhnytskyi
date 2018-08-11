using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeMarket.Errors;
using TradeMarket.Operations;

namespace TradeMarket
{
    public class OperationFactory: IOperationFactoty
    {
        private Dictionary<string, IOperation> operations = new Dictionary<string, IOperation>();
        public OperationFactory()
        {
            operations.Add("BUY", new BuyOperation());
        }

        public IOperation GetOperation(string key)
        {
            IOperation operation;
            if (!operations.TryGetValue(key, out operation))
            {
                throw new CommandNotFound();
            }

            return operation;
        }

    }
}
