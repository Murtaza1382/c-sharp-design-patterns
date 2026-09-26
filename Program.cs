
using design_patterns;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("======================================");
        Console.WriteLine("       OBSERVER PATTERN DEMO");
        Console.WriteLine("======================================");


        // -------------------------------------------------
        // Create the Publisher / Subject
        // -------------------------------------------------

        var orderService = new OrderService();


        // -------------------------------------------------
        // Create the Observers
        // -------------------------------------------------

        var paymentService = new PaymentService();

        var inventoryService = new InventoryService();

        var emailService = new EmailService();

        var analyticsService = new AnalyticsService();

        var auditService = new AuditService();


        // -------------------------------------------------
        // Subscribe the observers
        // -------------------------------------------------

        orderService.OrderCreated +=
            paymentService.HandleOrderCreated;

        orderService.OrderCreated +=
            inventoryService.HandleOrderCreated;

        orderService.OrderCreated +=
            emailService.HandleOrderCreated;

        orderService.OrderCreated +=
            analyticsService.HandleOrderCreated;

        orderService.OrderCreated +=
            auditService.HandleOrderCreated;


        // -------------------------------------------------
        // Create an Order
        // -------------------------------------------------

        var order = new Order(
            id: 1001,
            customerId: 501,
            totalAmount: 249.99m
        );


        // -------------------------------------------------
        // Create the order
        // -------------------------------------------------

        orderService.CreateOrder(order);


        // -------------------------------------------------
        // Keep console open
        // -------------------------------------------------

        Console.WriteLine();
        Console.WriteLine("======================================");
        Console.WriteLine("Press any key to exit...");
        Console.WriteLine("======================================");

        Console.ReadKey();
    }
}
