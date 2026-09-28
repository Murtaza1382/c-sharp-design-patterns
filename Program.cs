using design_patterns.Models;
using design_patterns.Services;
using design_patterns.Strategies;

Order order = new Order
{
    Id = 1001,
    OrderAmount = 500m,
    WeightKg = 10,
    DestinationCountry = "Germany"
};

// Start with Standard Shipping
IShippingStrategy standardShipping =
    new StandardShippingStrategy();

ShippingService shippingService =
    new ShippingService(standardShipping);

Console.WriteLine("STANDARD SHIPPING");

shippingService.CalculateShipping(order);


// Change strategy at runtime
Console.WriteLine();

Console.WriteLine("EXPRESS SHIPPING");

shippingService.SetShippingStrategy(
    new ExpressShippingStrategy());

shippingService.CalculateShipping(order);


// Change strategy again
Console.WriteLine();

Console.WriteLine("INTERNATIONAL SHIPPING");

shippingService.SetShippingStrategy(
    new InternationalShippingStrategy());

shippingService.CalculateShipping(order);


Console.WriteLine();

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
