class CardPaymentStrategy : IPaymentStrategy
{
    public async Task<bool> PayAsync(decimal amount)
    {

        Console.WriteLine($"Processing card payment: {amount}");
        Task<bool> task=new Task<bool>(()=>true);

        return  task.Wait(3000);
    }
}