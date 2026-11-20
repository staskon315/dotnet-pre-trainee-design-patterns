class LegacyPayPalClient
{
    public async Task<bool> MakePayment(double amountInUsd)
    {
        Console.WriteLine($"Processed outdated payment: {amountInUsd}");
        await Task.Delay(3000);
        return true;
    }
}