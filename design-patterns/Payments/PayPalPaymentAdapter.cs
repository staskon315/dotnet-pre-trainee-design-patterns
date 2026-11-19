class PayPalPaymentAdapter : IPaymentStrategy
{
    public Task<bool> PayAsync(decimal amount)
    {
        throw new NotImplementedException();
    }
}