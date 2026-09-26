using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    public class EmailService
    {
        public void HandleOrderCreated(object? sender, OrderCreatedEventArgs e)
        {
            Console.WriteLine($"[Email] Sending confirmation email to Customer #{e.CustomerId}. ");
        }
    }
}
