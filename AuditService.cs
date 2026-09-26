using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    public class AuditService
    {
        public void HandleOrderCreated(object? sender, OrderCreatedEventArgs e)
        {
            Console.WriteLine($"[Audit] Recording Order #{e.OrderId} in audit log.");
        }
    }
}
