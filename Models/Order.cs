using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal OrderAmount { get; set; }
        public double WeightKg { get; set; }
        public string DestinationCountry { get; set; } = string.Empty;
           

    }
}
