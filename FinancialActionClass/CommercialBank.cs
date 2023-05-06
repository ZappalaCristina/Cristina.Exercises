using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialActionClass
{
    internal class CommercialBank : FinancialIntermediary 
    {
        public void BuyCrypto(FinancialIntermediary financialIntermediary)
        {
            base.BuyAsset(financialIntermediary);
        }
        public void BuyStocks(FinancialIntermediary financialIntermediary)
        {
            base.BuyAsset(financialIntermediary);
        }
    }
}
