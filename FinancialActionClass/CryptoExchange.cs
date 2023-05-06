using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialActionClass
{
    internal class CryptoExchange : CryptoIntermediary 
    {
        internal protected override Asset BuyAsset (FinancialIntermediary financialIntermediary)
        {
            Console.WriteLine($"Stai acquistando Crypto da {this.Name}");
            return null;
        }
    }
}
