class OldBankApi
{
    public bool TransferMoney(string amountInUsd)
    {
        Console.WriteLine($"Processed outdated payment: {amountInUsd}");
        Thread.Sleep(5000);//emulation of a veeeeeery old API
        return true;
    }
}