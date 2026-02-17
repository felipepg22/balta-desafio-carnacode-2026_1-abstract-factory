namespace DesignPatternChallenge.PaymentGateways.Common;

public interface ICardValidator
{
    public bool ValidateCard(string cardNumber);
}