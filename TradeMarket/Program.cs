using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeMarket
{
    class Program
    {
        private const string escapeCode = "Q";
       
        static void Main(string[] args)
        {
            string input = string.Empty;
            var inputProcessing = new InputProcessing();
            Console.WriteLine("Type: 'Help' - available commands,  'Q' - for escape;");

            do
            {
                try
                {
                    input = Console.ReadLine();

                    inputProcessing.Process(input);
                }
                catch (Exception)
                {
                    //TODO error message
                    Console.WriteLine("Err");
                }
            } while (input.ToUpperInvariant() != escapeCode);
           
        }
    }
}
