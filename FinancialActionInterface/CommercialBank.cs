using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FinancialActionInterface
{
    public class CommercialBank : ICryptoIntermediary, IStockIntermediary
    {
        ICryptoIntermediary _cryptoIntermediary;
        IStockIntermediary _stockIntermediary; 
        
        
        public CommercialBank(ICryptoIntermediary cryptoIntermediary, IStockIntermediary stockIntermediary)
        {
            _cryptoIntermediary = cryptoIntermediary;
            _stockIntermediary = stockIntermediary; 
        }
        public void BuyCrypto()
        {
            _cryptoIntermediary.BuyCrypto(); 
        }
        public void BuyStock() 
        {
            _stockIntermediary.BuyStock(); 
        }
        
    }
}
