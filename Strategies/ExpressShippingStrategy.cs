using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Strategies
{
    public class ExpressShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost(double weightKg, decimal orderAmount)
        {
            decimal baseCost = 15m;
            decimal weightCost = (decimal)weightKg * 3m;
            return baseCost + weightCost;
        }
        public int CalculateDeliveryDays()
        {
            return 2;
        }
        public string GetShippingName()
        {
            return "Express Shipping";
        }
    }
}
