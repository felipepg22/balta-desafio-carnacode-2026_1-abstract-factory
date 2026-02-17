namespace AbstractFactoryChallenge.PaymentGateways.Common;

public interface ICardValidator
{
    public bool ValidateCard(string cardNumber);
}