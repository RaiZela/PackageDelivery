using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDelivery
{
    class OvernightPackage : Package
    {
        public decimal additionalFeePerOunce;
        public OvernightPackage() 
        {
            additionalFeePerOunce = 5;
        }

        public override decimal calculateCost()
        {
            decimal cost = base.calculateCost() + (weight * additionalFeePerOunce);
            return cost;
        }
    }
}
