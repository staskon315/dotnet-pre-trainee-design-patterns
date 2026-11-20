class CheckoutService
{
    public event EventHandler<Order>? OrderCompleted;
    public async Task Checkout(IPaymentStrategy strategy, Order order)
    {
        var result = await strategy.PayAsync(order.TotalAmount);

        if (result.Result)
        {
            Console.WriteLine("Payment successful.");
            Console.WriteLine("Order completed.");
            order.IsCompleted = true;
            OrderCompleted?.Invoke(this, order);
        }
        else
        {
            Console.WriteLine("Payment failed. Order was not completed.");
            order.IsCompleted = false;
        }
    }

}