class CardPaymentStrategy : IPaymentStrategy
{
    public async Task<bool> PayAsync(decimal amount)
    {
        Console.WriteLine($"Processing card payment: {amount}");
        await Task.Delay(3000);
        return true;
    }
}