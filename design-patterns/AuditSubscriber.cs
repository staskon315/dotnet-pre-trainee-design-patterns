class AuditSubscriber
{
    public void OnOrderCompleted(Order order)
    {
        Console.WriteLine($"Order {order.Id} completed and added to audit log.");
    }
}