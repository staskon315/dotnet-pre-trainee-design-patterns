class PayPalPaymentAdapter : IPaymentStrategy
{
    public async Task<PaymentResult> PayAsync(decimal amount)
    {
        var legacy= new LegacyPayPalClient();
        double convertAmount=Convert.ToDouble(amount);
        var isCompleted= await legacy.MakePayment(convertAmount);
        var result =new PaymentResult(isCompleted,amount);
        return result;
    }
}