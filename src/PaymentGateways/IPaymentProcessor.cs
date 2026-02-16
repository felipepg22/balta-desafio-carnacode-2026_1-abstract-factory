namespace DesignPatternChallenge;

public interface IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber);s
}