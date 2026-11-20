class PaymentStrategyFactory
{
    public bool TryCreate(string paymentType, out IPaymentStrategy? strategy)
    {

        switch (paymentType)
        {
            case "Bank Transfer":
                strategy = new BankTransferPaymentStrategy();
                return true;
            case "Card":
                strategy = new CardPaymentStrategy();
                return true;
            case "PayPal":
                strategy = new PayPalPaymentAdapter();
                return true;
            case "Crypto":
                strategy = new CryptoPaymentStrategy();
                return true;
            default:
                strategy = null;
                return false;
        }
    }
}