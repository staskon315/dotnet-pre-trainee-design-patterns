class CardPaymentStrategy : IPaymentStrategy
{
    public async Task<PaymentResult> PayAsync(decimal amount)
    {
        Console.WriteLine($"Processing card payment: {amount}");
        await Task.Delay(3000);
        var result =new PaymentResult(true,amount);
        return result;
    }
}