namespace DesignPatternChallenge.PaymentGateways.Common;

public interface IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber);s
}