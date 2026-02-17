using AbstractFactoryChallenge.PaymentGateways.Common;

namespace AbstractFactoryChallenge.PaymentGateways.Factories;

public class PagSeguroPaymentFactory : IPaymentGatewayFactory
{
    public ICardValidator CreateCardValidator()
    {
        throw new NotImplementedException();
    }

    public IPaymentLogger CreatePaymentLogger()
    {
        throw new NotImplementedException();
    }

    public IPaymentProcessor CreatePaymentProcessor()
    {
        throw new NotImplementedException();
    }
}