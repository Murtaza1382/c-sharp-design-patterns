using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    public class PaymentService
    {
        public void HandleOrderCreated(Object? sender, OrderCreatedEventArgs e)
        {
            Console.WriteLine($"[Payment] Processing payment for Order #{e.OrderId}. " + $"Amount: ${e.TotalAmount}");
        }
    }
}
