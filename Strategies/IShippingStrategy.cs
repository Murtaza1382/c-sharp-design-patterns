using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Strategies
{
    public interface IShippingStrategy
    {
        decimal CalculateShippingCost(double weightKg, decimal orderAmount);
        int CalculateDeliveryDays();
        string GetShippingName();
    }
}
