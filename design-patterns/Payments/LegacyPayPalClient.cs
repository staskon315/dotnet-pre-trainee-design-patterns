class LegacyPayPalClient
{
    public bool MakePayment(double amountInUsd)
    {
        Console.WriteLine($"Processed outdated payment: {amountInUsd}");
        Thread.Sleep(3000);
        return true;
    }
}