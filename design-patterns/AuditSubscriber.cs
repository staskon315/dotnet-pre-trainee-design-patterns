class AuditSubscriber
{
    public void OnOrderCompleted(object? sender, Order e)
    {
        Console.WriteLine($"Order {e.Id} completed and added to audit log.");
    }
}