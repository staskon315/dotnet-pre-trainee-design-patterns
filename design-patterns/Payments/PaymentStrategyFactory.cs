class PaymentStrategyFactory
{
    public bool TryCreate(string paymentType, out IPaymentStrategy? strategy)
    {

        switch (paymentType)
        {
            case "BankTransfer":
                strategy = new BankTransferPaymentStrategy();
                return true;
            case "CardPayment":
                strategy = new CardPaymentStrategy();
                return true;
            case "LegacyPayPalClient":
                strategy = new PayPalPaymentAdapter();
                return true;
            default:
                strategy = null;
                return false;
        }
    }
}