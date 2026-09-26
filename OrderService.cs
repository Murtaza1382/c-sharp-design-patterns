using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    public class OrderService
    {
        public event EventHandler<OrderCreatedEventArgs>? OrderCreated;
        public void CreateOrder(Order order)
        {
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine($"Creating Order #{order.Id}");
            Console.WriteLine("=================================");

            SaveOrder(order);
            Console.WriteLine();
            Console.WriteLine(
                $"Order #{order.Id} has been successfully created."
            );
            // Create event data
            var eventArgs = new OrderCreatedEventArgs(
                order.Id,
                order.CustomerId,
                order.TotalAmount
            );

            // Notify all subscribers
            OrderCreated?.Invoke(this, eventArgs);
        }
        private void SaveOrder(Order order)
        {
            Console.WriteLine(
                $"[Database] Saving Order #{order.Id}..."
            );

            Console.WriteLine(
                $"[Database] Customer: {order.CustomerId}"
            );

            Console.WriteLine(
                $"[Database] Total: ${order.TotalAmount}"
            );
        }
    }
}
