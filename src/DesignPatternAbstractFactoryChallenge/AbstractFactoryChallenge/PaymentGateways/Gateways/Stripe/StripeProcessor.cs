using AbstractFactoryChallenge.PaymentGateways.Common;

namespace AbstractFactoryChallenge.PaymentGateways.Gateways.Stripe;

public class StripeProcessor : IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"Stripe: Processando ${amount}...");
        return $"STRIPE-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }
}

