using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialActionInterface
{
    public class StockMarket : IStockIntermediary 
    {
        public void BuyStock()
        {
            Console.WriteLine("Stai acquistando Stock");
        }
    }
}
