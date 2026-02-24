namespace AbstractFactoryChallenge.PaymentGateways.Common
{
    public interface IPaymentProcessor
    {
        public string ProcessTransaction(decimal amount, string cardNumber);
    }
}