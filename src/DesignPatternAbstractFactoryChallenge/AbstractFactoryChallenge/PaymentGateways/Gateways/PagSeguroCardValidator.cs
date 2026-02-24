using AbstractFactoryChallenge.PaymentGateways.Common;

namespace AbstractFactoryChallenge.PaymentGateways.Gateways;

public class PagSeguroCardValidator : ICardValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("PagSeguro: Validando cartão...");
        return cardNumber.Length == 16;
    }
}