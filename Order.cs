using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    public class Order
    {
        public int Id { get; }
        public int CustomerId { get; }
        public decimal TotalAmount { get; }

        public Order(int id, int customerId, decimal totalAmount) {
            Id = id;
            CustomerId = customerId;
            TotalAmount = totalAmount;
        }
    }
}
    