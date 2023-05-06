using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialActionClass
{
    internal class StockMarket : StockIntermediary 
    {
        protected internal override Asset BuyAsset(FinancialIntermediary financialIntermediary)
        {
            Console.WriteLine($"Stai acquistando Stock da {this.Name}");
            return null;
        }
    }
}
