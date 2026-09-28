using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Strategies
{
    public class StandardShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost( double weightKg, decimal orderAmount)
        {
            decimal baseCost = 5m;
            decimal weightCost = (decimal)weightKg * 1.5m;
            return baseCost + weightCost;

        }
        public int CalculateDeliveryDays()
        {
            return 5;
        }
        public string GetShippingName()
        {
            return "Standard Shipping";
        }
    }
}
