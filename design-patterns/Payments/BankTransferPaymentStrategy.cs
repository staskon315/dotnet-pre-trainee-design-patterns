class BankTransferPaymentStrategy : IPaymentStrategy
{
    public async Task<bool> PayAsync(decimal amount)
    {
        Console.WriteLine($"Creating bank transfer for {amount}");
        await Task.Delay(3000);
        return true;
    }
}