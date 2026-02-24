using AbstractFactoryChallenge.PaymentGateways.Common;

namespace AbstractFactoryChallenge.PaymentGateways.Gateways;

public class PagSeguroLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {message}");
    }
}