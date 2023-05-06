using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialActionInterface
{
    public class CryptoExchange : ICryptoIntermediary 
    {
        public void BuyCrypto()
        {
            Console.WriteLine("Stai acquistando Crypto"); 
        }
    }
}
