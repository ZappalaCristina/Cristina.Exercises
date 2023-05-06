using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialActionClass
{
    internal class StockIntermediary : FinancialIntermediary 
    {
        public StockIntermediary() 
        { 

        }

        protected internal override Asset BuyAsset(FinancialIntermediary financialIntermediary)
        {
            Console.WriteLine($"Stai acquistando un Asset di tipo Stock"); 
            return null;
        }
    }
}
