using design_patterns.Models;
using design_patterns.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Services
{
    public class ShippingService
    {
        private IShippingStrategy _shippingStrategy;
        public ShippingService(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }
        public void SetShippingStrategy(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }
        public void CalculateShipping(Order order)
        {
            decimal shippingCost = _shippingStrategy.CalculateShippingCost(order.WeightKg, order.OrderAmount);
            int deliveryDays = _shippingStrategy.CalculateDeliveryDays();
            string shippingName = _shippingStrategy.GetShippingName();

            Console.WriteLine("---------------------------");
            Console.WriteLine($"Shipping Method : {shippingName}");
            Console.WriteLine($"Order Amount: ${order.OrderAmount}");
            Console.WriteLine($"Weight:{order.WeightKg} kg");
            Console.WriteLine($"Shipping Cost: ${shippingCost}");
            Console.WriteLine($"Estimated Delivery: {deliveryDays} days");
            Console.WriteLine("----------------------------");




                
        }
    }
}
