interface IPaymentStrategy
{
    public  Task<PaymentResult> PayAsync(decimal amount);
}