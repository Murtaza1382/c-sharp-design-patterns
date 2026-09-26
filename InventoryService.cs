using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    public  class InventoryService
    {
        public void HandleOrderCreated(object? sender, OrderCreatedEventArgs e)
        {
            Console.WriteLine($"[Inventory] Updating inventory for Order #{e.OrderId}.");
        }
    }
}
