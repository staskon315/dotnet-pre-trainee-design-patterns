interface IPaymentStrategy
{
    public  Task<bool> PayAsync(decimal amount);
}