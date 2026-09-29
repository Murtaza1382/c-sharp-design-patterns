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

Console.WriteLine("====================> Enter the type of Shipping Method <=============");
Console.WriteLine("Shipping methods = { standard, express, international");
Console.WriteLine("Enter the shipping method: ");
string ShippingMethod = Console.ReadLine();
ShippingService shippingService =
    new ShippingService();
if (ShippingMethod == "standard")
{

// Start with Standard Shipping
IShippingStrategy standardShipping =
    new StandardShippingStrategy();
    shippingService.SetShippingStrategy(standardShipping);



Console.WriteLine("STANDARD SHIPPING");

shippingService.CalculateShipping(order);
}
else
    if(ShippingMethod == "express")
    {

Console.WriteLine("EXPRESS SHIPPING");

shippingService.SetShippingStrategy(
    new ExpressShippingStrategy());

shippingService.CalculateShipping(order);
    }else
        if(ShippingMethod == "international")
        {

Console.WriteLine("INTERNATIONAL SHIPPING");

shippingService.SetShippingStrategy(
    new InternationalShippingStrategy());

shippingService.CalculateShipping(order);
        }
        else
        {
            Console.WriteLine("Invalid Input Try again");
        }



// Change strategy at runtime
//Console.WriteLine();



// Change strategy again
//Console.WriteLine();



Console.WriteLine();

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
