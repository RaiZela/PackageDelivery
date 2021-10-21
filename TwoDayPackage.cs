using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDelivery
{
    class TwoDayPackage : Package 
    {
        public decimal flatFee { get; set; }
        public TwoDayPackage(decimal flatFee) 
        {
            this.flatFee = flatFee;
        }

        public override decimal calculateCost()
        {
            decimal kosto = base.calculateCost() + flatFee;
            return kosto;
        }
    }
}
