static class Program
{
    static async Task Main()
    {
        var checkoutService = new CheckoutService();
        var auditSubscriber = new AuditSubscriber();
        var factory = new PaymentStrategyFactory();
        IPaymentStrategy? strategy;

        checkoutService.OrderCompleted += auditSubscriber.OnOrderCompleted;
        checkoutService.OrderCompleted += (sender, e) => Console.WriteLine($"Order confirmation sent to {e.CustomerName}.");

        Console.WriteLine("\nEnter the client's name.");
        Console.Write("Input: ");
        string name = ValidationService.GetValidInputForString();

        Console.WriteLine("Enter the payment amount");
        Console.Write("Input: ");
        decimal amount = ValidationService.GetValidInputForNumber();

        var order = new Order(name, amount);


        string strategyStr = SelectPayment();
        if (!factory.TryCreate(strategyStr, out strategy))
        {
            Console.WriteLine("Failed to create a payment method");
        }

        Console.WriteLine($"Processing {strategyStr} payment...");

        await checkoutService?.Checkout(strategy!,order)!;
    }

    static string SelectPayment()
    {
        decimal choise;

        while (true)
        {
            Console.WriteLine("Select a payment method:");
            Console.WriteLine("1. Card");
            Console.WriteLine("2. PayPal");
            Console.WriteLine("3. Bank Transfer");
            Console.WriteLine("4. Crypto");
            Console.Write("Input: ");
            choise = ValidationService.GetValidInputForNumber();
            switch (choise)
            {
                case 1:
                    return "Card";
                case 2:
                    return "PayPal";
                case 3:
                    return "Bank Transfer";
                case 4:
                    return "Crypto";
                default:
                    Console.WriteLine("there is no such answer option");
                    break;
            }
        }
    }
}

