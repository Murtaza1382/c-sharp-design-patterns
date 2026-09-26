using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    public class AnalyticsService
    {
        public void HandleOrderCreated(object? sender, OrderCreatedEventArgs e)
        {
            Console.WriteLine($"[Analytics] Recording Order #{e.OrderId} " + $"with value ${e.TotalAmount}.");
        }
    }
}
