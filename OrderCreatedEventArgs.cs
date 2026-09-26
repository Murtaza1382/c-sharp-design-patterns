using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    public class OrderCreatedEventArgs : EventArgs
    {
        public int OrderId { get; }
        public int CustomerId { get; }
        public decimal TotalAmount { get; }

        public OrderCreatedEventArgs(int orderId, int customerId, decimal totalAmount)
        {
            OrderId = orderId;
            CustomerId = customerId;
            TotalAmount = totalAmount;
        }
    }
}
