class CheckoutService
{
    public event EventHandler<Order>? OrderCompleted;
    public async Task Checkout(IPaymentStrategy strategy, Order order, decimal amount)
    {
        var result = await strategy.PayAsync(amount);

        if (result.Result)
        {
            order.IsCompleted = true;
            OrderCompleted?.Invoke(this, order);
        }
        else
        {
            Console.WriteLine("Payment failed");
            order.IsCompleted = false;
        }
    }

}