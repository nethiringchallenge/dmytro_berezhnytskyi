using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeMarket.Errors;

namespace TradeMarket
{
    public class InputProcessing
    {
        private IOperationFactoty operationFactoty;

        public InputProcessing()
        {
            operationFactoty = new OperationFactory();
        }

        public void Process(string input)
        {
            var arr = input.Split(' ');
            if (arr.Length != 3)
            {
                throw new CommandWrongFormat();
            }

            var operation = operationFactoty.GetOperation(arr[0]);
            operation.Execute(arr);

        }
    }
}
