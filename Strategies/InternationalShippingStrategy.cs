using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Strategies
{
    public   class InternationalShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost(double weightKg, decimal orderAmount)
        {
            decimal baseCost = 30m;
            decimal weightCost = (decimal)weightKg * 7m;
            decimal customsFee = orderAmount * 0.05m;
            return baseCost + weightCost + customsFee;
        }
        public int CalculateDeliveryDays()
        {
            return 14;
        }
        public string GetShippingName()
        {
            return "International Shipping";
        }
    }
}
