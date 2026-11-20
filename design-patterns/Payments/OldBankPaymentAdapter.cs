class OldBankPaymentAdapter : IPaymentStrategy
{
    public async Task<PaymentResult> PayAsync(decimal amount)
    {
        var oldBank = new OldBankApi();
        string convertAmount = Convert.ToString(amount);
        var isCompleted = oldBank.TransferMoney(convertAmount);
        var result = new PaymentResult(isCompleted, amount);
        return result;
    }
}