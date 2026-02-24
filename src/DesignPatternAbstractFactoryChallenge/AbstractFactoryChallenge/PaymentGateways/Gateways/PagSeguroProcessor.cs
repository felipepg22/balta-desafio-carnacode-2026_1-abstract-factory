using AbstractFactoryChallenge.PaymentGateways.Common;

namespace AbstractFactoryChallenge.PaymentGateways.Gateways;

public class PagSeguroProcessor : IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"PagSeguro: Processando R$ {amount}...");
        return $"PAGSEG-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }
}