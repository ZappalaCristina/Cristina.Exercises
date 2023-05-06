using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialActionClass
{
    internal abstract class FinancialIntermediary
    {

        public string Name { get; set; }
        internal protected virtual Asset BuyAsset (FinancialIntermediary financialIntermediary) 
        {
            return financialIntermediary.BuyAsset(financialIntermediary);
        }
        internal class Asset
        {
           
        }


    }
}
